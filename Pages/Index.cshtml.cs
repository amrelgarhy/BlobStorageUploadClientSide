using Azure.Storage;
using Azure.Storage.Blobs;
using Azure.Storage.Sas;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BlobStorageUploadClientSide.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IConfiguration _configuration;

        public string SasToken { get; set; }
        public string BlobAccountUri { get; set; }
        public string ContainerName { get; set; }

        public IndexModel(ILogger<IndexModel> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;

            SasToken = GetContainerSas();
            BlobAccountUri = _configuration["Storage:BlobAccountUri"] ?? "";
            ContainerName = _configuration["Storage:ContainerName"] ?? "";
        }

        public void OnGet()
        {

        }

        public string GetContainerSas()
        {
            BlobContainerClient containerClient =
                new BlobContainerClient(_configuration["Storage:ConnectionString"],
                                                    _configuration["Storage:ContainerName"]);

            // Check whether this BlobContainerClient object has been authorized with Shared Key.
            if (containerClient.CanGenerateSasUri)
            {
                // Create a SAS token that's valid for one hour.
                BlobSasBuilder sasBuilder = new BlobSasBuilder()
                {
                    BlobContainerName = containerClient.Name,
                    Resource = "c"
                };

                sasBuilder.ExpiresOn = DateTimeOffset.UtcNow.AddHours(1);
                sasBuilder.SetPermissions(BlobContainerSasPermissions.Write);

                return sasBuilder.ToSasQueryParameters(new StorageSharedKeyCredential(_configuration["Storage:AccountName"], _configuration["Storage:AccountKey"])).ToString();
            }
            else
            {
                throw new Exception("BlobContainerClient is not authorized to generate Sas Uri.");
            }
        }
    }
}