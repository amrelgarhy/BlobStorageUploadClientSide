import { BlobServiceClient } from "@azure/storage-blob";

const uploadFiles = async (accountUrl, sasToken, containerName, files) => {
    const endpoint = `${accountUrl}?${sasToken}`;
    const blobServiceClient = new BlobServiceClient(endpoint);

    // Get a reference to the container
    const containerClient = blobServiceClient.getContainerClient(containerName);

    // Create a new progress bar element
    const progressBar = document.createElement("progress");
    document.body.appendChild(progressBar);

    
    // Create an array to store the promises for each file upload
    const promises = [];

    // Loop through the files to be uploaded
    for (const file of files) {
        // Get a reference to the blob
        const blobClient = containerClient.getBlockBlobClient(file.name);
        // Upload the file and store the promise
        promises.push(
            blobClient.uploadData(file, {
                onProgress: (ev) => {
                    // Update the progress bar
                    progressBar.value = ev.loadedBytes / file.size;
                }
            })
        );
    }

    // Wait for all the uploads to complete
    Promise.all(promises)
        .then(() => {
            console.log("Uploads complete!");
        })
        .catch(err => {
            console.error("Error uploading files:", err);
        });
};

export { uploadFiles };


