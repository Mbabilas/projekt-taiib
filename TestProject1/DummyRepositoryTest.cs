using System;
using Xunit;
using DataAccessLayer;
using System.Collections.Generic;
using Models;

namespace TestProject1
{
    public class DummyRepositoryTest
    {
        [Fact]
        public void DummyZolnierzRepositoryTest()
        {
            Database database = new Database();
            ZolnierzRepository zolnierzRepository = new ZolnierzRepository(database);
            Assert.Throws<ArgumentNullException>(() => zolnierzRepository.DeleteZolnierz(1));
        }
        [Fact]
        public void DummyArmiaRepositoryTest()
        {
            Database database = new Database();
            ArmiaRepository armiaRepository = new ArmiaRepository(database);
            Assert.Throws<ArgumentNullException>(() => armiaRepository.DeleteArmia(1));
        }
        [Fact]
        public void DummyBronRepositoryTest()
        {
            Database database = new Database();
            BronRepository bronRepository = new BronRepository(database);
            Assert.Throws<ArgumentNullException>(() => bronRepository.DeleteBron(1));
        }
        [Fact]
        public void DummyDywizjaRepositoryTest()
        {
            Database database = new Database();
            DywizjaRepository dywizjaRepository = new DywizjaRepository(database);
            Assert.Throws<ArgumentNullException>(() => dywizjaRepository.DeleteDywizja(1));
        }
        [Fact]
        public void DummyModelRepositoryTest()
        {
            Database database = new Database();
            ModelRepository modelRepository = new ModelRepository(database);
            Assert.Throws<ArgumentNullException>(() => modelRepository.DeleteModel(1));
        }
        [Fact]
        public void DummyStopienRepositoryTest()
        {
            Database database = new Database();
            StopienRepository stopienRepository = new StopienRepository(database);
            Assert.Throws<ArgumentNullException>(() => stopienRepository.DeleteStopien(1));
        }
        [Fact]
        public void DummyZgloszenieRepositoryTest()
        {
            Database database = new Database();
            ZgloszenieRepository zgloszenieRepository = new ZgloszenieRepository(database);
            Assert.Throws<ArgumentNullException>(() => zgloszenieRepository.DeleteZgloszenie(1));
        }
    }
}
