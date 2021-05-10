using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GathaoWeb.NetCore.Commons;
using GathaoWeb.NetCore.Models;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using Microsoft.Azure.Documents.Linq;

namespace GathaoWeb.NetCore.Services
{
    public class GathaoWebContentsService
    {
        static DocumentClient docClient = null;

        static readonly string databaseName = "GathaoWebContents";
        static readonly string collectionName = "Images";

        static async Task<bool> Initialize()
        {
            if (docClient != null)
                return true;

            try
            {
                docClient = new DocumentClient(new Uri(Configurations.CosmosEndpointUrl), Configurations.CosmosAuthKey);

                // Create the database - this can also be done through the portal
                await docClient.CreateDatabaseIfNotExistsAsync(new Database { Id = databaseName });

                // Create the collection - make sure to specify the RUs - has pricing implications
                // This can also be done through the portal

                await docClient.CreateDocumentCollectionIfNotExistsAsync(
                    UriFactory.CreateDatabaseUri(databaseName),
                    new DocumentCollection { Id = collectionName },
                    new RequestOptions { OfferThroughput = 400 }
                );

            }
            catch (Exception ex)
            {
                //Debug.WriteLine(ex);

                docClient = null;

                return false;
            }

            return true;
        }


        public async static Task<List<IllustListItem>> GetIllustItems()
        {
            var illuts = new List<IllustListItem>();

            if (!await Initialize())
                return illuts;

            var todoQuery = docClient.CreateDocumentQuery<IllustListItem>(
                UriFactory.CreateDocumentCollectionUri(databaseName, collectionName),
                new FeedOptions { MaxItemCount = -1, EnableCrossPartitionQuery = true })
                .AsDocumentQuery();

            while (todoQuery.HasMoreResults)
            {
                var queryResults = await todoQuery.ExecuteNextAsync<IllustListItem>();

                illuts.AddRange(queryResults);
            }

            return illuts;
        }
    }
}
