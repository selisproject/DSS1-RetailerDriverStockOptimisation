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
    ///This is a test class for DateTimeFormatTest and is intended
    ///to contain all DateTimeFormatTest NUnit Tests
    ///</summary>
    [TestFixture]
    [Description("DateTimeFormat Repository Tests")]
    [Category("DateTimeFormat Repository Tests")]
    internal class DateTimeFormatTests : NHibernateFixture
    {
        /// <summary>
        ///A test for testing the persistence of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the persistence of `DateTimeFormat`")]
        [Order(0)]
        public void DateTimeFormat_persistence_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var _applicationsystembo_applicationlanguage_datetimeformat = new zAppDev.DotNet.Framework.Identity.Model.ApplicationLanguage
            {
                Name = "ApplicationLanguage_Name",
                Code = "ApplicationLanguage_Code",
                Icon = (new System.Text.ASCIIEncoding()).GetBytes("TestValue_Icon"),
            };
            new PersistenceSpecification<zAppDev.DotNet.Framework.Identity.Model.DateTimeFormat>(Session)
            .CheckProperty(p => p.LongDatePattern, "DateTimeFormat_LongDatePattern")
            .CheckProperty(p => p.LongTimePattern, "DateTimeFormat_LongTimePattern")
            .CheckProperty(p => p.MonthDayPattern, "DateTimeFormat_MonthDayPattern")
            .CheckProperty(p => p.RFC1123Pattern, "DateTimeFormat_RFC1123Pattern")
            .CheckProperty(p => p.ShortDatePattern, "DateTimeFormat_ShortDatePattern")
            .CheckProperty(p => p.ShortTimePattern, "DateTimeFormat_ShortTimePattern")
            .CheckProperty(p => p.YearMonthPattern, "DateTimeFormat_YearMonthPattern")
            .CheckReference(p => p.ApplicationLanguage, _applicationsystembo_applicationlanguage_datetimeformat)
            .VerifyTheMappings();
        }

        /// <summary>
        ///A test for testing the filtering of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the filtering of `DateTimeFormat`")]
        [Order(1)]
        public void DateTimeFormat_filtering_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var repo = new Repository(Session);
            List<zAppDev.DotNet.Framework.Identity.Model.DateTimeFormat> results = null;
            Assert.DoesNotThrow(() =>
            {
                results = repo.GetAsQueryable<zAppDev.DotNet.Framework.Identity.Model.DateTimeFormat>(
                              a => true
                              && (a.LongDatePattern != string.Empty && a.LongDatePattern != null)
                              && (a.LongTimePattern != string.Empty && a.LongTimePattern != null)
                              && (a.MonthDayPattern != string.Empty && a.MonthDayPattern != null)
                              && (a.RFC1123Pattern != string.Empty && a.RFC1123Pattern != null)
                              && (a.ShortDatePattern != string.Empty && a.ShortDatePattern != null)
                              && (a.ShortTimePattern != string.Empty && a.ShortTimePattern != null)
                              && (a.YearMonthPattern != string.Empty && a.YearMonthPattern != null)
                              && a.ApplicationLanguage != null
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