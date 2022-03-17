using Flurl;
using Flurl.Http;
using System.Threading.Tasks;

namespace DotNetFramework.Core.API.REST
{
    static class RestTest
    {

        public static async Task<string> GetApiKeyAsync()
        {
            dynamic token = await "http://restful-booker.herokuapp.com/"
                .AppendPathSegment("auth")
                .PostJsonAsync(new
                {
                    username = "admin",
                    password = "password123"
                })
                .ReceiveJson();

            return token.token;
        }
    }
}
