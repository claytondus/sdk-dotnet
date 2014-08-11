namespace AuthorizeNet.Api.Controllers.Test
{
    using System;
    using System.Collections.Generic;
    using AuthorizeNet.Api.Contracts.V1;
    using AuthorizeNet.Api.Controllers;
    using AuthorizeNet.Api.Controllers.Bases;
    using AuthorizeNet.Util;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class AllGeneratedEnumTest : ApiCoreTestBase
    {

        [ClassInitialize]
        public new static void SetUpBeforeClass(TestContext context)
        {
            ApiCoreTestBase.SetUpBeforeClass(context);
        }

        [ClassCleanup]
        public new static void TearDownAfterClass()
        {
            ApiCoreTestBase.TearDownAfterClass();
        }

        [TestInitialize]
        public new void SetUp()
        {
            base.SetUp();
        }

        [TestCleanup]
        public new void TearDown()
        {
            base.TearDown();
        }


        //Generated by cs-enum-test on Mon 08/11/2014-13:25:03.60 
        [TestMethod]
        public void AllEnumTest()
        {

            foreach (var anEnum in Enum.GetValues(typeof(messageTypeEnum)))
            {
                var aValue = anEnum.ToString();
                messageTypeEnum enumFromValue;
                Assert.IsTrue(Enum.TryParse(aValue, out enumFromValue));
                Assert.AreEqual(anEnum, enumFromValue);
            }

            foreach (var anEnum in Enum.GetValues(typeof(bankAccountTypeEnum)))
            {
                var aValue = anEnum.ToString();
                bankAccountTypeEnum enumFromValue;
                Assert.IsTrue(Enum.TryParse(aValue, out enumFromValue));
                Assert.AreEqual(anEnum, enumFromValue);
            }

            foreach (var anEnum in Enum.GetValues(typeof(echeckTypeEnum)))
            {
                var aValue = anEnum.ToString();
                echeckTypeEnum enumFromValue;
                Assert.IsTrue(Enum.TryParse(aValue, out enumFromValue));
                Assert.AreEqual(anEnum, enumFromValue);
            }

            foreach (var anEnum in Enum.GetValues(typeof(ARBSubscriptionStatusEnum)))
            {
                var aValue = anEnum.ToString();
                ARBSubscriptionStatusEnum enumFromValue;
                Assert.IsTrue(Enum.TryParse(aValue, out enumFromValue));
                Assert.AreEqual(anEnum, enumFromValue);
            }

            foreach (var anEnum in Enum.GetValues(typeof(paymentMethodEnum)))
            {
                var aValue = anEnum.ToString();
                paymentMethodEnum enumFromValue;
                Assert.IsTrue(Enum.TryParse(aValue, out enumFromValue));
                Assert.AreEqual(anEnum, enumFromValue);
            }

            foreach (var anEnum in Enum.GetValues(typeof(ARBGetSubscriptionListOrderFieldEnum)))
            {
                var aValue = anEnum.ToString();
                ARBGetSubscriptionListOrderFieldEnum enumFromValue;
                Assert.IsTrue(Enum.TryParse(aValue, out enumFromValue));
                Assert.AreEqual(anEnum, enumFromValue);
            }

            foreach (var anEnum in Enum.GetValues(typeof(deviceActivationEnum)))
            {
                var aValue = anEnum.ToString();
                deviceActivationEnum enumFromValue;
                Assert.IsTrue(Enum.TryParse(aValue, out enumFromValue));
                Assert.AreEqual(anEnum, enumFromValue);
            }

            foreach (var anEnum in Enum.GetValues(typeof(EncodingType)))
            {
                var aValue = anEnum.ToString();
                EncodingType enumFromValue;
                Assert.IsTrue(Enum.TryParse(aValue, out enumFromValue));
                Assert.AreEqual(anEnum, enumFromValue);
            }

            foreach (var anEnum in Enum.GetValues(typeof(EncryptionAlgorithmType)))
            {
                var aValue = anEnum.ToString();
                EncryptionAlgorithmType enumFromValue;
                Assert.IsTrue(Enum.TryParse(aValue, out enumFromValue));
                Assert.AreEqual(anEnum, enumFromValue);
            }

            foreach (var anEnum in Enum.GetValues(typeof(OperationType)))
            {
                var aValue = anEnum.ToString();
                OperationType enumFromValue;
                Assert.IsTrue(Enum.TryParse(aValue, out enumFromValue));
                Assert.AreEqual(anEnum, enumFromValue);
            }

            foreach (var anEnum in Enum.GetValues(typeof(ItemChoiceType1)))
            {
                var aValue = anEnum.ToString();
                ItemChoiceType1 enumFromValue;
                Assert.IsTrue(Enum.TryParse(aValue, out enumFromValue));
                Assert.AreEqual(anEnum, enumFromValue);
            }

            foreach (var anEnum in Enum.GetValues(typeof(customerTypeEnum)))
            {
                var aValue = anEnum.ToString();
                customerTypeEnum enumFromValue;
                Assert.IsTrue(Enum.TryParse(aValue, out enumFromValue));
                Assert.AreEqual(anEnum, enumFromValue);
            }

            foreach (var anEnum in Enum.GetValues(typeof(ARBSubscriptionUnitEnum)))
            {
                var aValue = anEnum.ToString();
                ARBSubscriptionUnitEnum enumFromValue;
                Assert.IsTrue(Enum.TryParse(aValue, out enumFromValue));
                Assert.AreEqual(anEnum, enumFromValue);
            }

            foreach (var anEnum in Enum.GetValues(typeof(ItemChoiceType)))
            {
                var aValue = anEnum.ToString();
                ItemChoiceType enumFromValue;
                Assert.IsTrue(Enum.TryParse(aValue, out enumFromValue));
                Assert.AreEqual(anEnum, enumFromValue);
            }

            foreach (var anEnum in Enum.GetValues(typeof(validationModeEnum)))
            {
                var aValue = anEnum.ToString();
                validationModeEnum enumFromValue;
                Assert.IsTrue(Enum.TryParse(aValue, out enumFromValue));
                Assert.AreEqual(anEnum, enumFromValue);
            }

            foreach (var anEnum in Enum.GetValues(typeof(splitTenderStatusEnum)))
            {
                var aValue = anEnum.ToString();
                splitTenderStatusEnum enumFromValue;
                Assert.IsTrue(Enum.TryParse(aValue, out enumFromValue));
                Assert.AreEqual(anEnum, enumFromValue);
            }

            foreach (var anEnum in Enum.GetValues(typeof(ARBGetSubscriptionListSearchTypeEnum)))
            {
                var aValue = anEnum.ToString();
                ARBGetSubscriptionListSearchTypeEnum enumFromValue;
                Assert.IsTrue(Enum.TryParse(aValue, out enumFromValue));
                Assert.AreEqual(anEnum, enumFromValue);
            }

            foreach (var anEnum in Enum.GetValues(typeof(accountTypeEnum)))
            {
                var aValue = anEnum.ToString();
                accountTypeEnum enumFromValue;
                Assert.IsTrue(Enum.TryParse(aValue, out enumFromValue));
                Assert.AreEqual(anEnum, enumFromValue);
            }

            foreach (var anEnum in Enum.GetValues(typeof(cardTypeEnum)))
            {
                var aValue = anEnum.ToString();
                cardTypeEnum enumFromValue;
                Assert.IsTrue(Enum.TryParse(aValue, out enumFromValue));
                Assert.AreEqual(anEnum, enumFromValue);
            }

            foreach (var anEnum in Enum.GetValues(typeof(FDSFilterActionEnum)))
            {
                var aValue = anEnum.ToString();
                FDSFilterActionEnum enumFromValue;
                Assert.IsTrue(Enum.TryParse(aValue, out enumFromValue));
                Assert.AreEqual(anEnum, enumFromValue);
            }

            foreach (var anEnum in Enum.GetValues(typeof(permissionsEnum)))
            {
                var aValue = anEnum.ToString();
                permissionsEnum enumFromValue;
                Assert.IsTrue(Enum.TryParse(aValue, out enumFromValue));
                Assert.AreEqual(anEnum, enumFromValue);
            }

            foreach (var anEnum in Enum.GetValues(typeof(settingNameEnum)))
            {
                var aValue = anEnum.ToString();
                settingNameEnum enumFromValue;
                Assert.IsTrue(Enum.TryParse(aValue, out enumFromValue));
                Assert.AreEqual(anEnum, enumFromValue);
            }

            foreach (var anEnum in Enum.GetValues(typeof(settlementStateEnum)))
            {
                var aValue = anEnum.ToString();
                settlementStateEnum enumFromValue;
                Assert.IsTrue(Enum.TryParse(aValue, out enumFromValue));
                Assert.AreEqual(anEnum, enumFromValue);
            }

            foreach (var anEnum in Enum.GetValues(typeof(transactionStatusEnum)))
            {
                var aValue = anEnum.ToString();
                transactionStatusEnum enumFromValue;
                Assert.IsTrue(Enum.TryParse(aValue, out enumFromValue));
                Assert.AreEqual(anEnum, enumFromValue);
            }

            foreach (var anEnum in Enum.GetValues(typeof(transactionTypeEnum)))
            {
                var aValue = anEnum.ToString();
                transactionTypeEnum enumFromValue;
                Assert.IsTrue(Enum.TryParse(aValue, out enumFromValue));
                Assert.AreEqual(anEnum, enumFromValue);
            }
        } 


        /*
        private <T extends enum > void XX<T>()
        {
            for ( T anEnum : T.values())
            {
                String unitValue = anEnum.value();
                T unitEnum = T.fromValue(unitValue);
                Assert.assertEquals(anEnum, unitEnum);			
            }
        }
        */
    }
}
