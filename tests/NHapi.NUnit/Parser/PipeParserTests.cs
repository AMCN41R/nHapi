namespace NHapi.NUnit.Parser
{
    using global::NUnit.Framework;

    using NHapi.Base.Parser;

    public class PipeParserTests
    {
        #region v23

        [Test]
        public void Parse_V23_ORM_O01()
        {
            var message = @"MSH|^~\&|sys1|sys1|sys2|sys2|20180503174921||ORM^O01|1234567890|P|2.3
PID|||1^^^XXX~2^^^YYY||LastName^FirstName||19660429|F
PV1||I|3906||||||||||||||||100001
ORC|CA|1410|3121||CA
OBR|1|1410|3121|RX50^ADDOME SUPINO";

            var parser = new PipeParser();

            var result = parser.Parse(message);

            var orm = result as NHapi.Model.V23.Message.ORM_O01;

            Assert.IsNotNull(orm);
            Assert.IsNotNull(orm.PATIENT?.PID);

            var givenName = orm.PATIENT.PID.GetPatientName(0).GivenName.Value;
            Assert.AreEqual("FirstName", givenName);
        }

        [Test]
        public void Parse_V23_ORM_O01_WithCustomEvnSegment()
        {
            var message = @"MSH|^~\&|sys1|sys1|sys2|sys2|20180503174921||ORM^O01|1234567890|P|2.4
EVN||20180503
PID|||1^^^XXX~2^^^YYY||LastName^FirstName||19660429|F
PV1||I|3906||||||||||||||||100001
ORC|CA|1410|3121||CA
OBR|1|1410|3121|RX50^ADDOME SUPINO";

            //            message = @"MSH|^~\&|sys1|sys1|sys2|sys2|20180503174921||ORM^O01|1234567890|P|2.3
            //PID |||1^^^XXX~2^^^YYY||LastName^FirstName||19660429|F
            //PV1||I|3906||||||||||||||||100001
            //ORC|CA|1410|3121||CA
            //OBR|1|1410|3121|RX50^ADDOME SUPINO
            //EVN||20180503";

            var parser = new PipeParser();

            var result = parser.Parse(message);

            var orm = result as NHapi.Model.V23.Message.ORM_O01;

            Assert.IsNotNull(orm);
            Assert.IsNotNull(orm.PATIENT?.PID);

            var givenName = orm.PATIENT.PID.GetPatientName(0).GivenName.Value;
            Assert.AreEqual("FirstName", givenName);
        }

        #endregion

        #region v24

        [Test]
        public void Parse_V24_ORM_O01()
        {
            var message = @"MSH|^~\&|sys1|sys1|sys2|sys2|20180503174921||ORM^O01|1234567890|P|2.4
PID|||1^^^XXX~2^^^YYY||LastName^FirstName||19660429|F
PV1||I|3906||||||||||||||||100001
ORC|CA|1410|3121||CA
OBR|1|1410|3121|RX50^ADDOME SUPINO";

            var parser = new PipeParser();

            var result = parser.Parse(message);

            var orm = result as NHapi.Model.V24.Message.ORM_O01;

            Assert.IsNotNull(orm);
            Assert.IsNotNull(orm.PATIENT?.PID);

            var givenName = orm.PATIENT.PID.GetPatientName(0).GivenName.Value;
            Assert.AreEqual("FirstName", givenName);
        }

        [Test]
        public void Parse_V24_ORM_O01_WithCustomEvnSegment()
        {
            var message = @"MSH|^~\&|sys1|sys1|sys2|sys2|20180503174921||ORM^O01|1234567890|P|2.4
EVN||20180503
PID|||1^^^XXX~2^^^YYY||LastName^FirstName||19660429|F
PV1||I|3906||||||||||||||||100001
ORC|CA|1410|3121||CA
OBR|1|1410|3121|RX50^ADDOME SUPINO";

            var parser = new PipeParser();

            var result = parser.Parse(message);

            var orm = result as NHapi.Model.V24.Message.ORM_O01;

            Assert.IsNotNull(orm);
            Assert.IsNotNull(orm.PATIENT?.PID);

            var givenName = orm.PATIENT.PID.GetPatientName(0).GivenName.Value;
            Assert.AreEqual("FirstName", givenName);
        }

        #endregion

        #region v25

        [Test]
        public void Parse_V25_ORM_O01()
        {
            var message = @"MSH|^~\&|sys1|sys1|sys2|sys2|20180503174921||ORM^O01|1234567890|P|2.5
PID|||1^^^XXX~2^^^YYY||LastName^FirstName||19660429|F
PV1||I|3906||||||||||||||||100001
ORC|CA|1410|3121||CA
OBR|1|1410|3121|RX50^ADDOME SUPINO";

            var parser = new PipeParser();

            var result = parser.Parse(message);

            var orm = result as NHapi.Model.V25.Message.ORM_O01;

            Assert.IsNotNull(orm);
            Assert.IsNotNull(orm.PATIENT?.PID);

            var givenName = orm.PATIENT.PID.GetPatientName(0).GivenName.Value;
            Assert.AreEqual("FirstName", givenName);
        }

        [Test]
        public void Parse_V25_ORM_O01_WithCustomEvnSegment()
        {
            var message = @"MSH|^~\&|sys1|sys1|sys2|sys2|20180503174921||ORM^O01|1234567890|P|2.5
EVN||20180503
PID|||1^^^XXX~2^^^YYY||LastName^FirstName||19660429|F
PV1||I|3906||||||||||||||||100001
ORC|CA|1410|3121||CA
OBR|1|1410|3121|RX50^ADDOME SUPINO";

            var parser = new PipeParser();

            var result = parser.Parse(message);

            var orm = result as NHapi.Model.V25.Message.ORM_O01;

            Assert.IsNotNull(orm);
            Assert.IsNotNull(orm.PATIENT?.PID);

            var givenName = orm.PATIENT.PID.GetPatientName(0).GivenName.Value;
            Assert.AreEqual("FirstName", givenName);
        }

        #endregion

        #region v251

        [Test]
        public void Parse_V251_ORM_O01()
        {
            var message = @"MSH|^~\&|sys1|sys1|sys2|sys2|20180503174921||ORM^O01|1234567890|P|2.5.1
PID|||1^^^XXX~2^^^YYY||LastName^FirstName||19660429|F
PV1||I|3906||||||||||||||||100001
ORC|CA|1410|3121||CA
OBR|1|1410|3121|RX50^ADDOME SUPINO";

            var parser = new PipeParser();

            var result = parser.Parse(message);

            var orm = result as NHapi.Model.V251.Message.ORM_O01;

            Assert.IsNotNull(orm);
            Assert.IsNotNull(orm.PATIENT?.PID);

            var givenName = orm.PATIENT.PID.GetPatientName(0).GivenName.Value;
            Assert.AreEqual("FirstName", givenName);
        }

        [Test]
        public void Parse_V251_ORM_O01_WithCustomEvnSegment()
        {
            var message = @"MSH|^~\&|sys1|sys1|sys2|sys2|20180503174921||ORM^O01|1234567890|P|2.5.1
EVN||20180503
PID|||1^^^XXX~2^^^YYY||LastName^FirstName||19660429|F
PV1||I|3906||||||||||||||||100001
ORC|CA|1410|3121||CA
OBR|1|1410|3121|RX50^ADDOME SUPINO";

            var parser = new PipeParser();

            var result = parser.Parse(message);

            var orm = result as NHapi.Model.V251.Message.ORM_O01;

            Assert.IsNotNull(orm);
            Assert.IsNotNull(orm.PATIENT?.PID);

            var givenName = orm.PATIENT.PID.GetPatientName(0).GivenName.Value;
            Assert.AreEqual("FirstName", givenName);
        }

        #endregion
    }
}
