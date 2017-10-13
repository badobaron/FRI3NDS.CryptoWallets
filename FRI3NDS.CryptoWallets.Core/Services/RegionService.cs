﻿using FRI3NDS.CryptoWallets.Core.Interfaces.Data;
using FRI3NDS.CryptoWallets.Core.Interfaces.Services;
using FRI3NDS.CryptoWallets.Core.Models.Domain;
using System;
using System.Collections.Generic;

namespace FRI3NDS.CryptoWallets.Core.Services
{
	/// <summary>
	/// Репозиторий регионов.
	/// </summary>
	public class RegionService : ServiceBase, IRegionService
	{
		public RegionService(IUnitOfWorkFactory unitOfWorkFactory)
			: base(unitOfWorkFactory)
		{
		}

		/// <summary>
		/// Получить регион по идентификатору.
		/// </summary>
		/// <param name="id">Идентификатор региона.</param>
		/// <returns>Регион, найденный по его идентификатору.</returns>
		public Region GetById(Guid id)
		{
			using (var uow = this.CreateUnitOfWork())
			{
				return uow.RegionRepository.GetById(id);
			}
		}

		/// <summary>
		/// Получить список регионов.
		/// </summary>
		/// <returns>Список регионов.</returns>
		public List<Region> Get()
		{
			using (var uow = this.CreateUnitOfWork())
			{
				return uow.RegionRepository.Get();
			}
		}
	}
}
