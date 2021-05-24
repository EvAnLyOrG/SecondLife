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
	public void Add_WithExistingName_ThenNull()
	{
		_repoMock.Setup(x => x.Exists(It.IsAny<User>())).Returns(true);
		var res = _service.Add(new User());
		Assert.IsNull(res);
	}

	[TestMethod]
	public void Add_WithNoName_ThenAddIsNotCalled()
	{
		var res = _service.Add(new User());
		_repoMock.Verify(x => x.Add(It.IsAny<User>()), Times.Never);
	}

	[TestMethod]
	public void Add_WithNoname_ThenRepoExistsIsCalled()
	{
		var res = _service.Add(new User());
		_repoMock.Verify(x => x.Exists(It.IsAny<User>()), Times.Never());
	}
}
