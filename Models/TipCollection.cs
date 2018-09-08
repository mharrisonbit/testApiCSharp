using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace WebApplication1.Models
{
    public class TipCollection
    {
        public JObject ReturningInfo()
        {
            var postData = new JObject(
                new JProperty("type", "bully_request"),
                new JProperty("title",
                    new JObject(
                        new JProperty("value", "Request")
                    )
                )
            );

            return postData;
        }

    }
}