using Amazon.ECR.Model;
using LibGit2Sharp;
using NuGet.Protocol.Core.Types;
using Octokit;
using System.Management.Automation;
using WebApplicationBilling.Models.DTO;
using WebApplicationBilling.Repository.Interfaces;

namespace WebApplicationBilling.Repository
{
    public class CustomerRepository : Repository<CustomerDTO>, ICustomerRepository
    {
        public CustomerRepository(IHttpClientFactory httpClientFactory)
            : base(httpClientFactory)
        {

        }
    }
}