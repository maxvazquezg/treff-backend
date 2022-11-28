﻿using Application.Interfaces;
using Application.Interfaces.Repositories;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.ServiceFeatures.Queries
{
    public class GetAllServicesPremiumByCategoryIdQuery : IRequest<IEnumerable<Service>>
    {
        public int Id { get; set; }
        public class GetAllServicesPremiumByCategoryIdQueryHandler : IRequestHandler<GetAllServicesPremiumByCategoryIdQuery, IEnumerable<Service>>
        {
            private readonly IServiceRepository _context;
            public GetAllServicesPremiumByCategoryIdQueryHandler(IServiceRepository context)
            {
                _context = context;
            }
            public async Task<IEnumerable<Service>> Handle(GetAllServicesPremiumByCategoryIdQuery query, CancellationToken cancellationToken)
            {
                var serviceList = await _context.GetAllServicesPremiumByCategoryIdAsync(query.Id);
                if (serviceList == null)
                {
                    return null;
                }
                return serviceList.AsReadOnly();
            }
        }
    }
}
