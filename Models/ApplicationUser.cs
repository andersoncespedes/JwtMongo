using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore.Identity.MongoDbCore.Models;
using MongoDbGenericRepository.Attributes;

namespace JwtMongo.Models;
[CollectionName("users")]
public class ApplicationUser : MongoIdentityUser<Guid>
{
    public string FullName {get; set;} = string.Empty;
}
