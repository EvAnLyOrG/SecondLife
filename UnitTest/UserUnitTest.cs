using System;
using SecondLife.Services.Interfaces;
using SecondLife.Services.Services;
using SecondLife.Services.Validators;
using SecondLife.Repositories.Repositories;
using SecondLife.Model.Entities;
using Moq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

public class UserUnitTest
{
	protected IService<User> _service;
	protected Mock<IRepository<User>> _repoMock;
	protected IValidator<User> _validator;
	public UserUnitTest()
	{
		_service = new GenericService<User>(_repoMock.Object, _validator);
		_repoMock = new Mock<IRepository<User>>();
	}

	[TestMethod]
	public void Add_WithExistingTitle_ThenNull()
	{
		_repoMock.Setup(x => x.Exists(It.IsAny<User>())).Returns(true);
		var res = _service.Add(new User());
		Assert.IsNull(res);
	}
}
