// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).

using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using FluentNHibernate.Testing;
using DSS1_RetailerDriverStockOptimisation.BO;
using DSS1_RetailerDriverStockOptimisation.BoTesting.Tests.Common;
using DSS1_RetailerDriverStockOptimisation.DAL;

namespace DSS1_RetailerDriverStockOptimisation.BoTesting.Tests
{
    /// <summary>
    ///This is a test class for StoreTest and is intended
    ///to contain all StoreTest NUnit Tests
    ///</summary>
    [TestFixture]
    [Description("Store Repository Tests")]
    [Category("Store Repository Tests")]
    internal class StoreTests : NHibernateFixture
    {
        /// <summary>
        ///A test for testing the persistence of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the persistence of `Store`")]
        [Order(0)]
        public void Store_persistence_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            new PersistenceSpecification<DSS1_RetailerDriverStockOptimisation.BO.Store>(Session)
            .CheckProperty(p => p.Code, "Store_Code")
            .CheckProperty(p => p.Description, "Store_Description")
            .VerifyTheMappings();
        }

        /// <summary>
        ///A test for testing the filtering of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the filtering of `Store`")]
        [Order(1)]
        public void Store_filtering_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var repo = new Repository(Session);
            List<DSS1_RetailerDriverStockOptimisation.BO.Store> results = null;
            Assert.DoesNotThrow(() =>
            {
                results = repo.GetAsQueryable<DSS1_RetailerDriverStockOptimisation.BO.Store>(
                              a => true
                              && (a.Code != string.Empty && a.Code != null)
                              && (a.Description != string.Empty && a.Description != null)
                              ,
                              cacheQuery: true)
                          .OrderBy(a => a)
                          .Skip(0)
                          .Take(3)
                          .ToList();
            });
            Assert.AreNotEqual(null, results);
        }
    }
}