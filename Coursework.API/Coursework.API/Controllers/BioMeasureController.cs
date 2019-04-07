﻿using Core.Entities.Origin;
using Coursework.API.DTOs;
using Data.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace Coursework.API.Controllers
{
    [Route("[controller]")]
    public class BioMeasureController : GenericContoller<BioMeasureDTO, BioMeasure>
    {
        public BioMeasureController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
