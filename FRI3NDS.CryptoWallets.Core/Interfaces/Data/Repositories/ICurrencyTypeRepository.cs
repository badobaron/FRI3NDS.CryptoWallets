﻿using FRI3NDS.CryptoWallets.Core.Models.Domain;
using System.Collections.Generic;

namespace FRI3NDS.CryptoWallets.Core.Interfaces.Data.Repositories
{
	/// <summary>
	/// Репозиторий типов валют.
	/// </summary>
	public interface ICurrencyTypeRepository : IRepositoryBase<CurrencyType>
	{
		/// <summary>
		/// Получить тип валюты по идентификатору статуса.
		/// </summary>
		/// <param name="id">Идентификатор типа валюты.</param>
		/// <returns>Тип валюты, найденный по его идентификатору.</returns>
		CurrencyType GetById(int id);

		/// <summary>
		/// Получить список типов валют.
		/// </summary>
		/// <returns>Список типов валют.</returns>
		List<CurrencyType> Get();
	}
}
