﻿using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Microsoft.AspNetCore.Http;
using SwanSong.Azure.Storage.Interfaces;
using SwanSong.Helper;
using System.IO;
using System.Threading.Tasks;

namespace SwanSong.Azure.Storage;

public class AzureStorageBlobHelper : Base, IAzureStorageBlobHelper
{
    public AzureStorageBlobHelper() : base()
    { }

    public async Task SaveBlobToAzureStorageContainerAsync(IFormFile file, string containerName, string fileName)
    {
        Stream fileStream = new MemoryStream();
        fileStream = file.OpenReadStream();
        var blobClient = new BlobContainerClient(GetStorageConnection(), containerName);
        var blob = blobClient.GetBlobClient(fileName);
        await blob.UploadAsync(fileStream, new BlobHttpHeaders { ContentType = Constants.ContentTypeImageJpg });

        return;
    }

    public async Task DeleteBlobInAzureStorageContainerAsync(string fileName, string containerName)
    {
        if (fileName == null)
        {
            return;
        }

        BlobServiceClient blobServiceClient = new(GetStorageConnection());
        BlobContainerClient container = blobServiceClient.GetBlobContainerClient(containerName);
        await container.DeleteBlobIfExistsAsync(fileName);

        return;
    }
}