﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CM.Payments.Client.Model;
using CM.Payments.Client.Enums;

//<auto-generated>
//	IMPORTANT NOTE:
//	This code is generated by MessageUnitTestGenerator in this project.
//	Date and time: 06-04-2018 14:52:27
//
//	Changes to this file may cause incorrect behavior and will be lost on the next code generation.
//</auto-generated>
namespace CM.Payments.Client.Test
{
	[TestClass, ExcludeFromCodeCoverage]
	public partial class ChargeResponseTests : BaseJsonConvertTests
	{
		public TestContext TestContext { get; set; }

		[TestMethod]
		public void ChargeResponse()
		{
			var obj = new ChargeResponse
			{
				Amount = 16,
				ChargeId = "Lorum_913",
				CreatedAt = DateTime.Now,
				Currency = "Lorum_883",
				Payments = new List<PaymentResponse>
				{
					new AfterPayPaymentResponse
					{
						Amount = 89,
						ChargeId = "Lorum_594",
						CreatedAt = DateTime.Now,
						Currency = "Lorum_369",
						Details = new AfterPayDetailsResponse
						{
							AuthenticationUrl = "Lorum_504",
							BankAccountNumber = "Lorum_483",
							BillToAddress = new AfterPayDetailsRequest.OrderAddress
							{
								City = "Lorum_527",
								HouseNumber = 54,
								HouseNumberAddition = "Lorum_149",
								IsoCountryCode = "Lorum_854",
								PostalCode = "Lorum_531",
								Reference = new AfterPayDetailsRequest.OrderAddress.ReferencePerson
								{
									DateOfBirth = DateTime.Now,
									EmailAddress = "Lorum_828",
									Gender = "Lorum_87",
									Initials = "Lorum_959",
									IsoLanguage = "Lorum_836",
									LastName = "Lorum_542",
									PhoneNumber1 = "Lorum_948",
									PhoneNumber2 = "Lorum_594"
								},
								Region = "Lorum_436",
								StreetName = "Lorum_648"
							},
							CallbackUrl = "Lorum_261",
							CancelledUrl = "Lorum_925",
							ExpiredUrl = "Lorum_418",
							FailedUrl = "Lorum_569",
							InvoiceNumber = "Lorum_490",
							IpAddress = "Lorum_244",
							Orderline = new List<AfterPayDetailsRequest.OrderLine>
							{
								new AfterPayDetailsRequest.OrderLine
								{
									ArticleDescription = "Lorum_881",
									ArticleId = "Lorum_993",
									NetUnitPrice = 94,
									Quantity = 55,
									UnitPrice = 95,
									VatCategory = AfterPayVatCategory.Low
								},
								new AfterPayDetailsRequest.OrderLine
								{
									ArticleDescription = "Lorum_257",
									ArticleId = "Lorum_65",
									NetUnitPrice = 31,
									Quantity = 17,
									UnitPrice = 6,
									VatCategory = AfterPayVatCategory.Zero
								}
							},
							OrderNumber = "Lorum_878",
							Password = "Lorum_298",
							PortfolioId = 88,
							PurchaseId = "Lorum_815",
							Result = new AfterPayDetailsResponse.ResultResponse
							{
								Checksum = "Lorum_577",
								OrderReference = "Lorum_857",
								ResultId = 69,
								StatusCode = "Lorum_655",
								TimestampIn = "Lorum_114",
								TimestampOut = "Lorum_53",
								TotalInvoicedAmount = 81,
								TotalReservedAmount = 70,
								TransactionId = "Lorum_259"
							},
							ShipToAddress = new AfterPayDetailsRequest.OrderAddress
							{
								City = "Lorum_567",
								HouseNumber = 8,
								HouseNumberAddition = "Lorum_264",
								IsoCountryCode = "Lorum_622",
								PostalCode = "Lorum_969",
								Reference = new AfterPayDetailsRequest.OrderAddress.ReferencePerson
								{
									DateOfBirth = DateTime.Now,
									EmailAddress = "Lorum_555",
									Gender = "Lorum_25",
									Initials = "Lorum_879",
									IsoLanguage = "Lorum_260",
									LastName = "Lorum_601",
									PhoneNumber1 = "Lorum_534",
									PhoneNumber2 = "Lorum_599"
								},
								Region = "Lorum_599",
								StreetName = "Lorum_896"
							},
							SuccessUrl = "Lorum_237",
							TotalOrderAmount = 57
						},
						DueDate = DateTime.Now,
						ExpiresAt = DateTime.Now,
						PaymentId = "Lorum_21",
						Recurring = false,
						RecurringId = "Lorum_673",
						ShortPaymentId = "Lorum_481",
						Status = "Lorum_273",
						Test = false,
						UpdatedAt = DateTime.Now
					},
					new AfterPayPaymentResponse
					{
						Amount = 14,
						ChargeId = "Lorum_445",
						CreatedAt = DateTime.Now,
						Currency = "Lorum_347",
						Details = new AfterPayDetailsResponse
						{
							AuthenticationUrl = "Lorum_560",
							BankAccountNumber = "Lorum_881",
							BillToAddress = new AfterPayDetailsRequest.OrderAddress
							{
								City = "Lorum_834",
								HouseNumber = 13,
								HouseNumberAddition = "Lorum_827",
								IsoCountryCode = "Lorum_179",
								PostalCode = "Lorum_239",
								Reference = new AfterPayDetailsRequest.OrderAddress.ReferencePerson
								{
									DateOfBirth = DateTime.Now,
									EmailAddress = "Lorum_290",
									Gender = "Lorum_389",
									Initials = "Lorum_219",
									IsoLanguage = "Lorum_992",
									LastName = "Lorum_443",
									PhoneNumber1 = "Lorum_341",
									PhoneNumber2 = "Lorum_606"
								},
								Region = "Lorum_35",
								StreetName = "Lorum_795"
							},
							CallbackUrl = "Lorum_618",
							CancelledUrl = "Lorum_696",
							ExpiredUrl = "Lorum_349",
							FailedUrl = "Lorum_216",
							InvoiceNumber = "Lorum_978",
							IpAddress = "Lorum_961",
							Orderline = new List<AfterPayDetailsRequest.OrderLine>
							{
								new AfterPayDetailsRequest.OrderLine
								{
									ArticleDescription = "Lorum_449",
									ArticleId = "Lorum_84",
									NetUnitPrice = 10,
									Quantity = 41,
									UnitPrice = 14,
									VatCategory = AfterPayVatCategory.High
								},
								new AfterPayDetailsRequest.OrderLine
								{
									ArticleDescription = "Lorum_985",
									ArticleId = "Lorum_851",
									NetUnitPrice = 93,
									Quantity = 50,
									UnitPrice = 18,
									VatCategory = AfterPayVatCategory.Zero
								}
							},
							OrderNumber = "Lorum_995",
							Password = "Lorum_143",
							PortfolioId = 5,
							PurchaseId = "Lorum_130",
							Result = new AfterPayDetailsResponse.ResultResponse
							{
								Checksum = "Lorum_774",
								OrderReference = "Lorum_354",
								ResultId = 36,
								StatusCode = "Lorum_308",
								TimestampIn = "Lorum_506",
								TimestampOut = "Lorum_18",
								TotalInvoicedAmount = 58,
								TotalReservedAmount = 58,
								TransactionId = "Lorum_305"
							},
							ShipToAddress = new AfterPayDetailsRequest.OrderAddress
							{
								City = "Lorum_66",
								HouseNumber = 45,
								HouseNumberAddition = "Lorum_478",
								IsoCountryCode = "Lorum_97",
								PostalCode = "Lorum_441",
								Reference = new AfterPayDetailsRequest.OrderAddress.ReferencePerson
								{
									DateOfBirth = DateTime.Now,
									EmailAddress = "Lorum_414",
									Gender = "Lorum_229",
									Initials = "Lorum_368",
									IsoLanguage = "Lorum_599",
									LastName = "Lorum_431",
									PhoneNumber1 = "Lorum_750",
									PhoneNumber2 = "Lorum_37"
								},
								Region = "Lorum_421",
								StreetName = "Lorum_40"
							},
							SuccessUrl = "Lorum_16",
							TotalOrderAmount = 31
						},
						DueDate = DateTime.Now,
						ExpiresAt = DateTime.Now,
						PaymentId = "Lorum_538",
						Recurring = false,
						RecurringId = "Lorum_492",
						ShortPaymentId = "Lorum_267",
						Status = "Lorum_719",
						Test = false,
						UpdatedAt = DateTime.Now
					}
				},
				Status = "Lorum_891",
				UpdatedAt = DateTime.Now
			};
			var deserialized = ConversionTest(obj);
			Assert.IsNotNull(deserialized);
			Assert.AreEqual(obj.ChargeId, deserialized.ChargeId);
			// Check only date and time up to seconds.. Json.NET does not save milliseconds.
			Assert.AreEqual(
				new DateTime(obj.CreatedAt.Year, obj.CreatedAt.Month, obj.CreatedAt.Day, obj.CreatedAt.Hour, obj.CreatedAt.Minute, obj.CreatedAt.Second),
				new DateTime(deserialized.CreatedAt.Year, deserialized.CreatedAt.Month, deserialized.CreatedAt.Day, deserialized.CreatedAt.Hour, deserialized.CreatedAt.Minute, deserialized.CreatedAt.Second));
			Assert.AreEqual(obj.Currency, deserialized.Currency);
			Assert.AreEqual(obj.Payments?.Count(), deserialized.Payments?.Count());
			for(var paymentsIndex = 0; paymentsIndex < obj.Payments.Count(); paymentsIndex++)
			{
				var expectedAfterPayPaymentResponseInPayments = obj.Payments.ElementAt(paymentsIndex) as AfterPayPaymentResponse;
				var actualAfterPayPaymentResponseInPayments = deserialized.Payments.ElementAt(paymentsIndex) as AfterPayPaymentResponse;
					Assert.AreEqual(expectedAfterPayPaymentResponseInPayments.ChargeId, actualAfterPayPaymentResponseInPayments.ChargeId);
					// Check only date and time up to seconds.. Json.NET does not save milliseconds.
					Assert.AreEqual(
						new DateTime(expectedAfterPayPaymentResponseInPayments.CreatedAt.Year, expectedAfterPayPaymentResponseInPayments.CreatedAt.Month, expectedAfterPayPaymentResponseInPayments.CreatedAt.Day, expectedAfterPayPaymentResponseInPayments.CreatedAt.Hour, expectedAfterPayPaymentResponseInPayments.CreatedAt.Minute, expectedAfterPayPaymentResponseInPayments.CreatedAt.Second),
						new DateTime(actualAfterPayPaymentResponseInPayments.CreatedAt.Year, actualAfterPayPaymentResponseInPayments.CreatedAt.Month, actualAfterPayPaymentResponseInPayments.CreatedAt.Day, actualAfterPayPaymentResponseInPayments.CreatedAt.Hour, actualAfterPayPaymentResponseInPayments.CreatedAt.Minute, actualAfterPayPaymentResponseInPayments.CreatedAt.Second));
					Assert.AreEqual(expectedAfterPayPaymentResponseInPayments.Currency, actualAfterPayPaymentResponseInPayments.Currency);
					Assert.AreEqual(expectedAfterPayPaymentResponseInPayments.Details.AuthenticationUrl, actualAfterPayPaymentResponseInPayments.Details.AuthenticationUrl);
					Assert.AreEqual(expectedAfterPayPaymentResponseInPayments.Details.BankAccountNumber, actualAfterPayPaymentResponseInPayments.Details.BankAccountNumber);
					Assert.AreEqual(expectedAfterPayPaymentResponseInPayments.Details.BillToAddress.City, actualAfterPayPaymentResponseInPayments.Details.BillToAddress.City);
					Assert.AreEqual(expectedAfterPayPaymentResponseInPayments.Details.BillToAddress.HouseNumber, actualAfterPayPaymentResponseInPayments.Details.BillToAddress.HouseNumber);
					Assert.AreEqual(expectedAfterPayPaymentResponseInPayments.Details.BillToAddress.HouseNumberAddition, actualAfterPayPaymentResponseInPayments.Details.BillToAddress.HouseNumberAddition);
					Assert.AreEqual(expectedAfterPayPaymentResponseInPayments.Details.BillToAddress.IsoCountryCode, actualAfterPayPaymentResponseInPayments.Details.BillToAddress.IsoCountryCode);
					Assert.AreEqual(expectedAfterPayPaymentResponseInPayments.Details.BillToAddress.PostalCode, actualAfterPayPaymentResponseInPayments.Details.BillToAddress.PostalCode);
					// Check only date and time up to seconds.. Json.NET does not save milliseconds.
					Assert.AreEqual(
						new DateTime(expectedAfterPayPaymentResponseInPayments.Details.BillToAddress.Reference.DateOfBirth.Year, expectedAfterPayPaymentResponseInPayments.Details.BillToAddress.Reference.DateOfBirth.Month, expectedAfterPayPaymentResponseInPayments.Details.BillToAddress.Reference.DateOfBirth.Day, expectedAfterPayPaymentResponseInPayments.Details.BillToAddress.Reference.DateOfBirth.Hour, expectedAfterPayPaymentResponseInPayments.Details.BillToAddress.Reference.DateOfBirth.Minute, expectedAfterPayPaymentResponseInPayments.Details.BillToAddress.Reference.DateOfBirth.Second),
						new DateTime(actualAfterPayPaymentResponseInPayments.Details.BillToAddress.Reference.DateOfBirth.Year, actualAfterPayPaymentResponseInPayments.Details.BillToAddress.Reference.DateOfBirth.Month, actualAfterPayPaymentResponseInPayments.Details.BillToAddress.Reference.DateOfBirth.Day, actualAfterPayPaymentResponseInPayments.Details.BillToAddress.Reference.DateOfBirth.Hour, actualAfterPayPaymentResponseInPayments.Details.BillToAddress.Reference.DateOfBirth.Minute, actualAfterPayPaymentResponseInPayments.Details.BillToAddress.Reference.DateOfBirth.Second));
					Assert.AreEqual(expectedAfterPayPaymentResponseInPayments.Details.BillToAddress.Reference.EmailAddress, actualAfterPayPaymentResponseInPayments.Details.BillToAddress.Reference.EmailAddress);
					Assert.AreEqual(expectedAfterPayPaymentResponseInPayments.Details.BillToAddress.Reference.Gender, actualAfterPayPaymentResponseInPayments.Details.BillToAddress.Reference.Gender);
					Assert.AreEqual(expectedAfterPayPaymentResponseInPayments.Details.BillToAddress.Reference.Initials, actualAfterPayPaymentResponseInPayments.Details.BillToAddress.Reference.Initials);
					Assert.AreEqual(expectedAfterPayPaymentResponseInPayments.Details.BillToAddress.Reference.IsoLanguage, actualAfterPayPaymentResponseInPayments.Details.BillToAddress.Reference.IsoLanguage);
					Assert.AreEqual(expectedAfterPayPaymentResponseInPayments.Details.BillToAddress.Reference.LastName, actualAfterPayPaymentResponseInPayments.Details.BillToAddress.Reference.LastName);
					Assert.AreEqual(expectedAfterPayPaymentResponseInPayments.Details.BillToAddress.Reference.PhoneNumber1, actualAfterPayPaymentResponseInPayments.Details.BillToAddress.Reference.PhoneNumber1);
					Assert.AreEqual(expectedAfterPayPaymentResponseInPayments.Details.BillToAddress.Reference.PhoneNumber2, actualAfterPayPaymentResponseInPayments.Details.BillToAddress.Reference.PhoneNumber2);
					Assert.AreEqual(expectedAfterPayPaymentResponseInPayments.Details.BillToAddress.Region, actualAfterPayPaymentResponseInPayments.Details.BillToAddress.Region);
					Assert.AreEqual(expectedAfterPayPaymentResponseInPayments.Details.BillToAddress.StreetName, actualAfterPayPaymentResponseInPayments.Details.BillToAddress.StreetName);
					Assert.AreEqual(expectedAfterPayPaymentResponseInPayments.Details.CallbackUrl, actualAfterPayPaymentResponseInPayments.Details.CallbackUrl);
					Assert.AreEqual(expectedAfterPayPaymentResponseInPayments.Details.CancelledUrl, actualAfterPayPaymentResponseInPayments.Details.CancelledUrl);
					Assert.AreEqual(expectedAfterPayPaymentResponseInPayments.Details.ExpiredUrl, actualAfterPayPaymentResponseInPayments.Details.ExpiredUrl);
					Assert.AreEqual(expectedAfterPayPaymentResponseInPayments.Details.FailedUrl, actualAfterPayPaymentResponseInPayments.Details.FailedUrl);
					Assert.AreEqual(expectedAfterPayPaymentResponseInPayments.Details.InvoiceNumber, actualAfterPayPaymentResponseInPayments.Details.InvoiceNumber);
					Assert.AreEqual(expectedAfterPayPaymentResponseInPayments.Details.IpAddress, actualAfterPayPaymentResponseInPayments.Details.IpAddress);
					Assert.AreEqual(expectedAfterPayPaymentResponseInPayments.Details.Orderline?.Count(), actualAfterPayPaymentResponseInPayments.Details.Orderline?.Count());
					for(var orderlineIndex = 0; orderlineIndex < expectedAfterPayPaymentResponseInPayments.Details.Orderline.Count(); orderlineIndex++)
					{
						var expectedOrderLineInOrderline = expectedAfterPayPaymentResponseInPayments.Details.Orderline.ElementAt(orderlineIndex) as AfterPayDetailsRequest.OrderLine;
						var actualOrderLineInOrderline = actualAfterPayPaymentResponseInPayments.Details.Orderline.ElementAt(orderlineIndex) as AfterPayDetailsRequest.OrderLine;
							Assert.AreEqual(expectedOrderLineInOrderline.ArticleDescription, actualOrderLineInOrderline.ArticleDescription);
							Assert.AreEqual(expectedOrderLineInOrderline.ArticleId, actualOrderLineInOrderline.ArticleId);
							Assert.AreEqual(expectedOrderLineInOrderline.NetUnitPrice, actualOrderLineInOrderline.NetUnitPrice);
							Assert.AreEqual(expectedOrderLineInOrderline.Quantity, actualOrderLineInOrderline.Quantity);
							Assert.AreEqual(expectedOrderLineInOrderline.UnitPrice, actualOrderLineInOrderline.UnitPrice);
							Assert.AreEqual(expectedOrderLineInOrderline.VatCategory, actualOrderLineInOrderline.VatCategory);
					}
					Assert.AreEqual(expectedAfterPayPaymentResponseInPayments.Details.OrderNumber, actualAfterPayPaymentResponseInPayments.Details.OrderNumber);
					Assert.AreEqual(expectedAfterPayPaymentResponseInPayments.Details.Password, actualAfterPayPaymentResponseInPayments.Details.Password);
					Assert.AreEqual(expectedAfterPayPaymentResponseInPayments.Details.PortfolioId, actualAfterPayPaymentResponseInPayments.Details.PortfolioId);
					Assert.AreEqual(expectedAfterPayPaymentResponseInPayments.Details.PurchaseId, actualAfterPayPaymentResponseInPayments.Details.PurchaseId);
					Assert.AreEqual(expectedAfterPayPaymentResponseInPayments.Details.Result.Checksum, actualAfterPayPaymentResponseInPayments.Details.Result.Checksum);
					Assert.AreEqual(expectedAfterPayPaymentResponseInPayments.Details.Result.OrderReference, actualAfterPayPaymentResponseInPayments.Details.Result.OrderReference);
					Assert.AreEqual(expectedAfterPayPaymentResponseInPayments.Details.Result.ResultId, actualAfterPayPaymentResponseInPayments.Details.Result.ResultId);
					Assert.AreEqual(expectedAfterPayPaymentResponseInPayments.Details.Result.StatusCode, actualAfterPayPaymentResponseInPayments.Details.Result.StatusCode);
					Assert.AreEqual(expectedAfterPayPaymentResponseInPayments.Details.Result.TimestampIn, actualAfterPayPaymentResponseInPayments.Details.Result.TimestampIn);
					Assert.AreEqual(expectedAfterPayPaymentResponseInPayments.Details.Result.TimestampOut, actualAfterPayPaymentResponseInPayments.Details.Result.TimestampOut);
					Assert.AreEqual(expectedAfterPayPaymentResponseInPayments.Details.Result.TotalInvoicedAmount, actualAfterPayPaymentResponseInPayments.Details.Result.TotalInvoicedAmount);
					Assert.AreEqual(expectedAfterPayPaymentResponseInPayments.Details.Result.TotalReservedAmount, actualAfterPayPaymentResponseInPayments.Details.Result.TotalReservedAmount);
					Assert.AreEqual(expectedAfterPayPaymentResponseInPayments.Details.Result.TransactionId, actualAfterPayPaymentResponseInPayments.Details.Result.TransactionId);
					Assert.AreEqual(expectedAfterPayPaymentResponseInPayments.Details.ShipToAddress.City, actualAfterPayPaymentResponseInPayments.Details.ShipToAddress.City);
					Assert.AreEqual(expectedAfterPayPaymentResponseInPayments.Details.ShipToAddress.HouseNumber, actualAfterPayPaymentResponseInPayments.Details.ShipToAddress.HouseNumber);
					Assert.AreEqual(expectedAfterPayPaymentResponseInPayments.Details.ShipToAddress.HouseNumberAddition, actualAfterPayPaymentResponseInPayments.Details.ShipToAddress.HouseNumberAddition);
					Assert.AreEqual(expectedAfterPayPaymentResponseInPayments.Details.ShipToAddress.IsoCountryCode, actualAfterPayPaymentResponseInPayments.Details.ShipToAddress.IsoCountryCode);
					Assert.AreEqual(expectedAfterPayPaymentResponseInPayments.Details.ShipToAddress.PostalCode, actualAfterPayPaymentResponseInPayments.Details.ShipToAddress.PostalCode);
					// Check only date and time up to seconds.. Json.NET does not save milliseconds.
					Assert.AreEqual(
						new DateTime(expectedAfterPayPaymentResponseInPayments.Details.ShipToAddress.Reference.DateOfBirth.Year, expectedAfterPayPaymentResponseInPayments.Details.ShipToAddress.Reference.DateOfBirth.Month, expectedAfterPayPaymentResponseInPayments.Details.ShipToAddress.Reference.DateOfBirth.Day, expectedAfterPayPaymentResponseInPayments.Details.ShipToAddress.Reference.DateOfBirth.Hour, expectedAfterPayPaymentResponseInPayments.Details.ShipToAddress.Reference.DateOfBirth.Minute, expectedAfterPayPaymentResponseInPayments.Details.ShipToAddress.Reference.DateOfBirth.Second),
						new DateTime(actualAfterPayPaymentResponseInPayments.Details.ShipToAddress.Reference.DateOfBirth.Year, actualAfterPayPaymentResponseInPayments.Details.ShipToAddress.Reference.DateOfBirth.Month, actualAfterPayPaymentResponseInPayments.Details.ShipToAddress.Reference.DateOfBirth.Day, actualAfterPayPaymentResponseInPayments.Details.ShipToAddress.Reference.DateOfBirth.Hour, actualAfterPayPaymentResponseInPayments.Details.ShipToAddress.Reference.DateOfBirth.Minute, actualAfterPayPaymentResponseInPayments.Details.ShipToAddress.Reference.DateOfBirth.Second));
					Assert.AreEqual(expectedAfterPayPaymentResponseInPayments.Details.ShipToAddress.Reference.EmailAddress, actualAfterPayPaymentResponseInPayments.Details.ShipToAddress.Reference.EmailAddress);
					Assert.AreEqual(expectedAfterPayPaymentResponseInPayments.Details.ShipToAddress.Reference.Gender, actualAfterPayPaymentResponseInPayments.Details.ShipToAddress.Reference.Gender);
					Assert.AreEqual(expectedAfterPayPaymentResponseInPayments.Details.ShipToAddress.Reference.Initials, actualAfterPayPaymentResponseInPayments.Details.ShipToAddress.Reference.Initials);
					Assert.AreEqual(expectedAfterPayPaymentResponseInPayments.Details.ShipToAddress.Reference.IsoLanguage, actualAfterPayPaymentResponseInPayments.Details.ShipToAddress.Reference.IsoLanguage);
					Assert.AreEqual(expectedAfterPayPaymentResponseInPayments.Details.ShipToAddress.Reference.LastName, actualAfterPayPaymentResponseInPayments.Details.ShipToAddress.Reference.LastName);
					Assert.AreEqual(expectedAfterPayPaymentResponseInPayments.Details.ShipToAddress.Reference.PhoneNumber1, actualAfterPayPaymentResponseInPayments.Details.ShipToAddress.Reference.PhoneNumber1);
					Assert.AreEqual(expectedAfterPayPaymentResponseInPayments.Details.ShipToAddress.Reference.PhoneNumber2, actualAfterPayPaymentResponseInPayments.Details.ShipToAddress.Reference.PhoneNumber2);
					Assert.AreEqual(expectedAfterPayPaymentResponseInPayments.Details.ShipToAddress.Region, actualAfterPayPaymentResponseInPayments.Details.ShipToAddress.Region);
					Assert.AreEqual(expectedAfterPayPaymentResponseInPayments.Details.ShipToAddress.StreetName, actualAfterPayPaymentResponseInPayments.Details.ShipToAddress.StreetName);
					Assert.AreEqual(expectedAfterPayPaymentResponseInPayments.Details.SuccessUrl, actualAfterPayPaymentResponseInPayments.Details.SuccessUrl);
					Assert.AreEqual(expectedAfterPayPaymentResponseInPayments.Details.TotalOrderAmount, actualAfterPayPaymentResponseInPayments.Details.TotalOrderAmount);
					// Check only date and time up to seconds.. Json.NET does not save milliseconds.
					Assert.AreEqual(
						new DateTime(expectedAfterPayPaymentResponseInPayments.DueDate.Year, expectedAfterPayPaymentResponseInPayments.DueDate.Month, expectedAfterPayPaymentResponseInPayments.DueDate.Day, expectedAfterPayPaymentResponseInPayments.DueDate.Hour, expectedAfterPayPaymentResponseInPayments.DueDate.Minute, expectedAfterPayPaymentResponseInPayments.DueDate.Second),
						new DateTime(actualAfterPayPaymentResponseInPayments.DueDate.Year, actualAfterPayPaymentResponseInPayments.DueDate.Month, actualAfterPayPaymentResponseInPayments.DueDate.Day, actualAfterPayPaymentResponseInPayments.DueDate.Hour, actualAfterPayPaymentResponseInPayments.DueDate.Minute, actualAfterPayPaymentResponseInPayments.DueDate.Second));
					// Check only date and time up to seconds.. Json.NET does not save milliseconds.
					Assert.AreEqual(
						new DateTime(expectedAfterPayPaymentResponseInPayments.ExpiresAt.Year, expectedAfterPayPaymentResponseInPayments.ExpiresAt.Month, expectedAfterPayPaymentResponseInPayments.ExpiresAt.Day, expectedAfterPayPaymentResponseInPayments.ExpiresAt.Hour, expectedAfterPayPaymentResponseInPayments.ExpiresAt.Minute, expectedAfterPayPaymentResponseInPayments.ExpiresAt.Second),
						new DateTime(actualAfterPayPaymentResponseInPayments.ExpiresAt.Year, actualAfterPayPaymentResponseInPayments.ExpiresAt.Month, actualAfterPayPaymentResponseInPayments.ExpiresAt.Day, actualAfterPayPaymentResponseInPayments.ExpiresAt.Hour, actualAfterPayPaymentResponseInPayments.ExpiresAt.Minute, actualAfterPayPaymentResponseInPayments.ExpiresAt.Second));
					Assert.AreEqual(expectedAfterPayPaymentResponseInPayments.PaymentId, actualAfterPayPaymentResponseInPayments.PaymentId);
					Assert.AreEqual(expectedAfterPayPaymentResponseInPayments.Recurring, actualAfterPayPaymentResponseInPayments.Recurring);
					Assert.AreEqual(expectedAfterPayPaymentResponseInPayments.RecurringId, actualAfterPayPaymentResponseInPayments.RecurringId);
					Assert.AreEqual(expectedAfterPayPaymentResponseInPayments.ShortPaymentId, actualAfterPayPaymentResponseInPayments.ShortPaymentId);
					Assert.AreEqual(expectedAfterPayPaymentResponseInPayments.Status, actualAfterPayPaymentResponseInPayments.Status);
					Assert.AreEqual(expectedAfterPayPaymentResponseInPayments.Test, actualAfterPayPaymentResponseInPayments.Test);
					// Check only date and time up to seconds.. Json.NET does not save milliseconds.
					Assert.AreEqual(
						new DateTime(expectedAfterPayPaymentResponseInPayments.UpdatedAt.Year, expectedAfterPayPaymentResponseInPayments.UpdatedAt.Month, expectedAfterPayPaymentResponseInPayments.UpdatedAt.Day, expectedAfterPayPaymentResponseInPayments.UpdatedAt.Hour, expectedAfterPayPaymentResponseInPayments.UpdatedAt.Minute, expectedAfterPayPaymentResponseInPayments.UpdatedAt.Second),
						new DateTime(actualAfterPayPaymentResponseInPayments.UpdatedAt.Year, actualAfterPayPaymentResponseInPayments.UpdatedAt.Month, actualAfterPayPaymentResponseInPayments.UpdatedAt.Day, actualAfterPayPaymentResponseInPayments.UpdatedAt.Hour, actualAfterPayPaymentResponseInPayments.UpdatedAt.Minute, actualAfterPayPaymentResponseInPayments.UpdatedAt.Second));
			}
			Assert.AreEqual(obj.Status, deserialized.Status);
			// Check only date and time up to seconds.. Json.NET does not save milliseconds.
			Assert.AreEqual(
				new DateTime(obj.UpdatedAt.Year, obj.UpdatedAt.Month, obj.UpdatedAt.Day, obj.UpdatedAt.Hour, obj.UpdatedAt.Minute, obj.UpdatedAt.Second),
				new DateTime(deserialized.UpdatedAt.Year, deserialized.UpdatedAt.Month, deserialized.UpdatedAt.Day, deserialized.UpdatedAt.Hour, deserialized.UpdatedAt.Minute, deserialized.UpdatedAt.Second));
		}
	}
}
