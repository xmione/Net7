using System;
using System.Linq;
using GhostUI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace GhostUI.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ContactInfoDataController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<ContactInfo> ContactInfos(int startDateIndex)
        {
            var rng = new Random().Next();
            
            return Enumerable.Range(1, 5).Select(index => new ContactInfo
            {
                Id = rng + index,
                EmailAddresses = string.Format("user{0}@test.com", rng + index),
                DeliveryAddress = string.Format("Test DeliveryAddress for user{0}", rng + index),
                BillingAddress = string.Format("Test BillingAddress for user{0}", rng + index),
                WorkPhone = string.Format("07{0}", GeneratRandomNumber(8)),
                HomePhone = string.Format("07{0}", GeneratRandomNumber(8)),
                MobilePhone = string.Format("07{0}", GeneratRandomNumber(8))
            })
            .ToArray();
        }
        /// <summary>
        /// Create a random number as a string with a maximum length.
        /// </summary>
        /// <param name="length">Length of number</param>
        /// <returns>Generated string</returns>
        private static string GeneratRandomNumber(int length)
        {
            if (length > 0)
            {
                var sb = new StringBuilder();

                var rnd = SeedRandom();
                for (int i = 0; i < length; i++)
                {
                    sb.Append(rnd.Next(0, 9).ToString());
                }

                return sb.ToString();
            }

            return string.Empty;
        }
        private static Random SeedRandom()
        {
            return new Random(Guid.NewGuid().GetHashCode());
        }
    }
}