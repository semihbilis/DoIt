using DoIt.DataAccess.Concrete.EntityFramework;
using DoIt.Entities.Concrete;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace DoIt.DataAccess.Tests.EntityFrameworkTests
{
    [TestClass]
    public class EfDatabaseClear
    {
        private EfDutyDal dutyDal = new EfDutyDal();
        private EfOrganizationDal organizationDal = new EfOrganizationDal();
        private EfProjectDal projectDal = new EfProjectDal();
        private EfQuoteDal quoteDal = new EfQuoteDal();
        private EfStatusDal statusDal = new EfStatusDal();
        private EfTagDal tagDal = new EfTagDal();
        private EfUserDal userDal = new EfUserDal();

        [TestMethod]
        [TestCategory("ClearDatabase")]
        public void DatabaseClear()
        {
            foreach (var duty in dutyDal.GetList())
            {
                dutyDal.Delete(duty);
            }
            foreach (var organization in organizationDal.GetList())
            {
                organizationDal.Delete(organization);
            }
            foreach (var project in projectDal.GetList())
            {
                projectDal.Delete(project);
            }
            foreach (var quote in quoteDal.GetList())
            {
                quoteDal.Delete(quote);
            }
            foreach (var status in statusDal.GetList())
            {
                statusDal.Delete(status);
            }
            foreach (var tag in tagDal.GetList())
            {
                tagDal.Delete(tag);
            }
            foreach (var user in userDal.GetList())
            {
                userDal.Delete(user);
            }
        }
    }
}
