using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;

namespace OptionsPattern
{
    public class ApplicationOptionsSetup: IConfigureOptions<ApplicationOptions>
    {
        private readonly IConfiguration _configuration;

        public ApplicationOptionsSetup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void Configure(ApplicationOptions options)
        {
            _configuration.GetSection(nameof(ApplicationOptions))
                .Bind(options);
        }
    }
}