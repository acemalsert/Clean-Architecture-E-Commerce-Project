using EComm.Application.Bases;
using EComm.Application.Features.Auth.Rules;
using EComm.Application.Interfaces.AutoMapper;
using EComm.Application.Interfaces.UnitOfWorks;
using EComm.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComm.Application.Features.Auth.Commands.Revoke
{
    public class RevokeCommandRequest : IRequest<Unit>
    {
        public string Email { get; set; }
    }

}
