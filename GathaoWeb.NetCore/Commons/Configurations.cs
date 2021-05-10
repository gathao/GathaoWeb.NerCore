using Microsoft.Extensions.Configuration;

namespace GathaoWeb.NetCore.Commons
{
    public static class Configurations
    {
        private static IConfiguration Configuration = null;

        public static void LoadConfigration(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public static string CosmosEndpointUrl
        {
            get
            {
                if (Configuration == null)
                {
                    // logging error
                    return "";
                }

                return Configuration["CosmosEndpointUrl"];
            }
        }

        public static string CosmosAuthKey
        {
            get
            {
                if (Configuration == null)
                {
                    // logging error
                    return "";
                }

                return Configuration["CosmosAuthKey"];
            }
        }
    }
}
