// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Samples
{
    public partial class Samples_ResourceManagerClient
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ResourceManager_GetNumber_ShortVersion()
        {
            Uri endpoint = new Uri("<endpoint>");
            ResourceManagerClient client = new ResourceManagerClient(endpoint);

            using RequestContent content = RequestContent.Create(new
            {
                value = 1234,
            });
            Response response = client.GetNumber(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("options").GetProperty("value").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ResourceManager_GetNumber_ShortVersion_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            ResourceManagerClient client = new ResourceManagerClient(endpoint);

            using RequestContent content = RequestContent.Create(new
            {
                value = 1234,
            });
            Response response = await client.GetNumberAsync(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("options").GetProperty("value").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ResourceManager_GetNumber_ShortVersion_Convenience()
        {
            Uri endpoint = new Uri("<endpoint>");
            ResourceManagerClient client = new ResourceManagerClient(endpoint);

            DiskOptions foo = new DiskOptions(1234);
            Response<Wrapper> response = client.GetNumber(foo);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ResourceManager_GetNumber_ShortVersion_Convenience_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            ResourceManagerClient client = new ResourceManagerClient(endpoint);

            DiskOptions foo = new DiskOptions(1234);
            Response<Wrapper> response = await client.GetNumberAsync(foo);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ResourceManager_GetNumber_AllParameters()
        {
            Uri endpoint = new Uri("<endpoint>");
            ResourceManagerClient client = new ResourceManagerClient(endpoint);

            using RequestContent content = RequestContent.Create(new
            {
                value = 1234,
            });
            Response response = client.GetNumber(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("options").GetProperty("value").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ResourceManager_GetNumber_AllParameters_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            ResourceManagerClient client = new ResourceManagerClient(endpoint);

            using RequestContent content = RequestContent.Create(new
            {
                value = 1234,
            });
            Response response = await client.GetNumberAsync(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("options").GetProperty("value").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ResourceManager_GetNumber_AllParameters_Convenience()
        {
            Uri endpoint = new Uri("<endpoint>");
            ResourceManagerClient client = new ResourceManagerClient(endpoint);

            DiskOptions foo = new DiskOptions(1234);
            Response<Wrapper> response = client.GetNumber(foo);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ResourceManager_GetNumber_AllParameters_Convenience_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            ResourceManagerClient client = new ResourceManagerClient(endpoint);

            DiskOptions foo = new DiskOptions(1234);
            Response<Wrapper> response = await client.GetNumberAsync(foo);
        }
    }
}
