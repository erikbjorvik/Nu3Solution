using System;
using Nu3.Api.Services.Interfaces;
using Nu3.Configuration;
using Nu3.Services.Interfaces;
using Nu3Core.Models;

namespace Nu3.Api.Services
{
    public class IntakeHelper : IIntakeHelper
    {
        private readonly IDataAccessProvider _dataAccessProvider;
        public IntakeHelper(IDataAccessProvider dataAccessProvider)
        {
            _dataAccessProvider = dataAccessProvider;
        }

        public Intake Add(Intake intake)
        {
            return _dataAccessProvider.Create(intake, DatabaseConfiguration.IntakeEntity);
        }
    }
}
