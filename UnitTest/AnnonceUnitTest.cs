using SecondLife.Services.Interfaces;
using SecondLife.Services.Services;
using SecondLife.Services.Validators;
using SecondLife.Repositories.Repositories;
using SecondLife.Model.Entities;
using Moq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SecondLife.UnitTest
{
    class AnnonceUnitTest
    {
		protected IService<Annonce> _service;
		protected Mock<IRepository<Annonce>> _repoMock;
		protected IValidator<Annonce> _validator;
		public AnnonceUnitTest()
		{
			_service = new GenericService<Annonce>(_repoMock.Object, _validator);
			_repoMock = new Mock<IRepository<Annonce>>();
		}

		[TestMethod]
		public void Add_WithExistingTitle_ThenNull()
		{
			_repoMock.Setup(x => x.Exists(It.IsAny<Annonce>())).Returns(true);
			var res = _service.Add(new Annonce());
			Assert.IsNull(res);
		}

		[TestMethod]
		public void Add_WithNoTitle_ThenAddIsNotCalled()
		{
			var res = _service.Add(new Annonce());
			_repoMock.Verify(x => x.Add(It.IsAny<Annonce>()), Times.Never);
		}

		[TestMethod]
		public void Add_WithNoTitle_ThenRepoExistsIsCalled()
		{
			var res = _service.Add(new Annonce());
			_repoMock.Verify(x => x.Exists(It.IsAny<Annonce>()), Times.Never());
		}

	}


}
