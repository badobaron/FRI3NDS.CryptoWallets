﻿using FRI3NDS.CryptoWallets.Core.Models.Domain;
using System;
using System.Collections.Generic;

namespace FRI3NDS.CryptoWallets.Core.Interfaces.Data.Repositories
{
	/// <summary>
	/// Репозиторий стран.
	/// </summary>
	public interface ICountryRepository : IRepositoryBase<Country>
	{
		/// <summary>
		/// Получить страну по идентификатору.
		/// </summary>
		/// <param name="id">Идентификатор страны.</param>
		/// <returns>Страна, найденная по ее идентификатору.</returns>
		Country GetById(Guid id);

		/// <summary>
		/// Получить список стран.
		/// </summary>
		/// <param name="countryId">Идентификатор страны.</param>
		/// <param name="pageSize">Размер страницы.</param>
		/// <param name="pageNumber">Номер страницы.</param>
		/// <returns></returns>
		List<Country> Get(
			Guid? countryId = null,
			int? pageSize = null,
			int? pageNumber = null);
	}
}
