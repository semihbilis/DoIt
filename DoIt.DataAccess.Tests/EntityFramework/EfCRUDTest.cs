using DoIt.DataAccess.Concrete.EntityFramework;
using DoIt.Entities.Concrete;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace DoIt.DataAccess.Tests.EntityFramework
{
    [TestClass]
    public class EfCRUDTest
    {
        private EfUserDal userDal = new EfUserDal();
        private EfOrganizationDal organizationDal = new EfOrganizationDal();
        private EfProjectDal projectDal = new EfProjectDal();
        private EfStatusDal statusDal = new EfStatusDal();
        private EfDutyDal dutyDal = new EfDutyDal();
        private EfTagDal tagDal = new EfTagDal();
        private EfQuoteDal quoteDal = new EfQuoteDal();

        private User user;
        private Organization organization;
        private Project project;
        private Status status;
        private Duty duty;
        private List<Duty> duties;
        private Tag tag;
        private Quote quote;

        [TestMethod, TestCategory("EntityAdd")]
        public void EntityAddTable()
        {
            EntitiesCreate();

            tagDal.Add(tag);
            quoteDal.Add(quote);
        }

        [TestMethod, TestCategory("GetEntities")]
        public void GetEntities()
        {
            Assert.IsNotNull(organizationDal.GetList());
            Assert.IsNotNull(projectDal.GetList());
            Assert.IsNotNull(statusDal.GetList());
            Assert.IsNotNull(dutyDal.GetList());
            Assert.IsNotNull(tagDal.GetList());
            Assert.IsNotNull(quoteDal.GetList());
            Assert.IsNotNull(userDal.GetList());
        }

        public void EntitiesCreate()
        {
            user = new User()
            {
                Name = "testName",
                Surname = "testSurname",
                Email = "asd@as",
                Password = "123",
                CreateDate = DateTime.Now
            };
            organization = new Organization()
            {
                Name = "testOrganization",
                CreateDate = DateTime.Now,
            };
            project = new Project()
            {
                Name = "testProject",
                CreateDate = DateTime.Now,
                Organization = organization
            };
            status = new Status()
            {
                Name = "testStatus",
                Icon = "C:/test.ico",
                CreateDate = DateTime.Now,
                Project = project
            };
            duty = new Duty()
            {
                Text = "testDuty",
                Priority = 1,
                CreateDate = DateTime.Now,
                Status = status
            };
            duties = new List<Duty>();
            duties.Add(duty);
            tag = new Tag()
            {
                Text = "testTag",
                Color = "Blue",
                CreateDate = DateTime.Now,
                Duties = duties
            };
            quote = new Quote()
            {
                Text = "testQuote",
                CreateDate = DateTime.Now,
                User = user
            };
        }
    }
}
