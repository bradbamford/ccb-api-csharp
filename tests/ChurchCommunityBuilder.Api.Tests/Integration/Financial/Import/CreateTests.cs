using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shouldly;
using NUnit.Framework;
using ChurchCommunityBuilder.Api;
using ChurchCommunityBuilder.Api.Financial.Entity.Import;

namespace ChurchCommunityBuilder.Api.Tests.Integration.Financial.Import {
    [TestFixture]
    public class CreateTests : BaseTest {
        [Test]
        public void integration_financial_create_batch_import() {
            var rnd = new Random();

            var batch = new Batch {
                Campus = new Lookup {
                    ID = 1
                },
                InAccountingPackage = true,
                PostDate = DateTime.UtcNow,
                BeginDate = DateTime.UtcNow
            };

            batch.Transactions.Add(new Transaction {
                Campus = new Lookup {
                    ID = 1
                },
                Individual = new Lookup {
                    ID = 4103
                },
                PaymentType = "check",
                Date = DateTime.UtcNow,
                Grouping = new Lookup {
                    ID = 1
                },
                TransactionDetails = new List<TransactionDetail> {
                    new TransactionDetail {
                        COA = new Lookup {
                            ID = 44
                        },
                        TaxDeductible = false,
                        Amount = rnd.Next(3, 176),
                        Created = DateTime.UtcNow
                    }
                }
            });

            var returnBatch = base.ApiClient.Financials.Batches.Create(batch);
            returnBatch.ShouldNotBe(null);
        }
    }
}
