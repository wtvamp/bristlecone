﻿using Bristlecone.DataAccessLayer.Repositories.Interfaces;
using Bristlecone.DataLayer.Common;
using Bristlecone.DataLayer.Entities;

namespace Bristlecone.DataLayer.EfRepositories
{
    /// <summary>
    /// Derivative repository for interacting with Bristlecone Application Entities using Entity Framework
    /// </summary>
    public class ApplicationEfRavenRepository : GenericEfRepository<Application>, IApplicationRepository
    {
        /// <summary>
        /// Creates a new Entity Framework backed Application Repository
        /// </summary>
        /// <param name="context"></param>
        public ApplicationEfRavenRepository(BaseDbContext context) : base(context)
        {

        }
    }
}