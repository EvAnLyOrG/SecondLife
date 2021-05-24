using System;
using SecondLife.Services.Interfaces;
using SecondLife.Services.Services;
using SecondLife.Services.Validators;
using SecondLife.Repositories.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

[TestClass]
public class GenericUnitTest<T> where T : class
{
	protected IService<T> _service;
	protected Mock<IRepository<T>> _repoMock;
	protected IValidator<T> _validator;

	public GenericUnitTest()
	{
		_service = new GenericService<T>(_repoMock.Object, _validator);
		_repoMock = new Mock<IRepository<T>>();
	}

	[TestMethod]
	public void Add_Null_ThenHasError()
    {
		var res = _service.Add(null);
		Assert.IsNull(res);
	}
}
