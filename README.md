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

![devenv_8G9yqUERcH](https://user-images.githubusercontent.com/660190/216196220-f0344ea9-deb5-4e2e-bb6b-569da561ca94.png)

![devenv_KHosm2aMSy](https://user-images.githubusercontent.com/660190/216196283-de37111a-ae66-4c2c-9d94-5e0f11c4a2f9.png)

![devenv_mvwmKqoj2d](https://user-images.githubusercontent.com/660190/216196317-65e748c6-2cd0-4abe-8fe1-e7f356af6fa2.png)

![devenv_INsaSpwvRK](https://user-images.githubusercontent.com/660190/216196349-d369c265-ac36-4f49-a954-e86ae891a4f8.png)

![devenv_QRrnljrPB2](https://user-images.githubusercontent.com/660190/216196397-baefabab-656d-41e5-8e39-22257ada263c.png)

![devenv_bnL2ZlLgzP](https://user-images.githubusercontent.com/660190/216196431-5b06831c-501b-4196-8035-36ad7b058305.png)

![devenv_nwSbj8WWH7](https://user-images.githubusercontent.com/660190/216196455-c91caa6d-05b0-45f7-98a8-a1db8baf5eb4.png)

![devenv_1xiKFB0WE3](https://user-images.githubusercontent.com/660190/216196480-79dc9238-19ac-4c30-9130-b22baa9c4aa5.png)

![devenv_lFzPuBgR7b](https://user-images.githubusercontent.com/660190/216196504-ab94cb8f-0066-41eb-871a-fc035258ba9e.png)

![chrome_k4lrFpEvsk](https://user-images.githubusercontent.com/660190/216196519-fee011a8-4aae-4a1a-a242-db4a684f791e.png)

![chrome_2PQW8Fv5fN](https://user-images.githubusercontent.com/660190/216196542-da610162-0ec5-40eb-a729-844910aec7fa.png)

![devenv_HbQH4NwrKp](https://user-images.githubusercontent.com/660190/216196572-48742ac3-4fc2-463b-ab73-c68d52c500ab.png)




