var client = new HttpClient();
var response = await client.PostAsync("https://example.com/api/endpoint", new StringContent("Hello, World!", Encoding.UTF8, "text/plain"));
