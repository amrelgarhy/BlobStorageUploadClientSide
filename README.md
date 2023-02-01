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

# Step by step
- Create new ASP.Net Core website using Visual Stuio
- Add Azure.Storage.Blobs nuget package
- Add configuration keys in appsettings.json file
- Install Azure Blob Storage node modules
	- `npm install @azure/storage-blob` run this in the terminal
- Create a new file webpack.config.js and add add your webpack config (source and dist files)
- Install webpack-cli
	- `npm install --save-dev webpack webpack-cli`
- Add webpack command on build inside the .csproj file
- Build the project
	- This should generate the bundle file in the configured dist folder
- Write down the upload page HTML
	- Reference the generated bundle js file
- Allow getting the Sas token through the server side c#

