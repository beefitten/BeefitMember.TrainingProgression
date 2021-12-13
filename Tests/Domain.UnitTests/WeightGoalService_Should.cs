using System;
using System.Net;
using System.Threading.Tasks;
using AutoFixture.Xunit2;
using Domain.Services;
using Domain.Services.Models;
using Moq;
using Persistance.Models;
using Persistance.Repositories;
using Persistence.Repositories.WeightGoalRepository;
using Xunit;
using Xunit.Sdk;

namespace Tests.Domain.UnitTests
{
    public class WeightGoalService_Should
    {
        [Theory, AutoData]
        public async Task Call_Create__Expect_HttpStatusCode_OK(
            [Frozen] Mock<IWeightGoalRepository> repoMock,
            CreateWeightGoalModel model)
        {
            //Arrange
            var sut = new WeightGoalService(repoMock.Object);

            //Act
            var response = await sut.Create(model);

            //Assert
            Assert.Equal(HttpStatusCode.OK, response);
        }

        [Theory, AutoData]
        public async Task Call_get__Expect_WeightGoalModel(
            [Frozen] Mock<IWeightGoalRepository> repoMock,
            string email,
            ReturnModel model)
        {
            //Arrange
            repoMock
                .Setup(x => x.Get(email))
                .ReturnsAsync(model);

            //Act
            var sut = new WeightGoalService(repoMock.Object);
            var respone = await sut.Get(email);

            //Assert
            Assert.Equal(model, respone);
        }
    }
}