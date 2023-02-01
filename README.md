# Blob Storage Upload ClientSide

This small project show how to upload files to Azure Blob Storage using [Azure Blob Storage SDK](https://learn.microsoft.com/en-us/javascript/api/@azure/storage-blob/?view=azure-node-latest) in an ASP.Net Core website using Visual Studio 2022


# Quick Config and Run the project

- Open solution BlobStorageUploadClientSide.sln
- Run `npx webpack` in the terminal to install the SDK node modules
- Open appsettings.json and put your own azure blob account credentials

    "Storage": {
            "ConnectionString": "DefaultEndpointsProtocol=https;AccountName=ACCOUNTNAME;AccountKey=ACCOUNTKEY;EndpointSuffix=core.windows.net",
            "BlobAccountUri": "https://ACCOUNTNAME.blob.core.windows.net",
            "ContainerName": "myuploadtestcontainer",
            "AccountName": "ACCOUNTNAME",
            "AccountKey": "ACCOUNTKEY"
          },
- Run the website and test uploading files
