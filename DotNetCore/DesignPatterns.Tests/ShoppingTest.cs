using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shopping;
using System;

namespace DesignPatterns.Tests
{
    [TestClass]
    public class ShoppingTest
    {
        [TestMethod]
        public void Should_add_item_into_an_in_progress_order()
        {
            IOrder order = new Order();
            var item = new Item();
            order.AddItem(item);
            
            Assert.IsTrue(order.Items.Contains(item));
        }

        [TestMethod]
        [ExpectedException(typeof(NotSupportedException))]
        public void Should_throw_notSuportedException_when_adding_an_item_into_a_validated_order()
        {
            var order = new Order();
            order.NextStatus();
            var item = new Item();
            order.AddItem(item);
        }

        [TestMethod]
        [ExpectedException(typeof(NotSupportedException))]
        public void Should_throw_notSupportedException_when_adding_an_item_into_a_delivered_order()
        {
            var order = new Order();
            order.NextStatus();
            order.NextStatus();
            var item = new Item();
            order.AddItem(item);
        }
        
        [TestMethod]
        public void Should_remove_item_from_the_order_when_it_is_in_progress()
        {
            var order = new Order();
            var item = new Item();
            order.AddItem(item);

            order.RemoveItem(item);
            
            Assert.IsFalse(order.Items.Contains(item));
        }

        [TestMethod]
        public void Should_remove_item_from_the_order_when_it_is_validated()
        {
            IOrder order = new Order();
            var item = new Item();
            order.AddItem(item);
            order.NextStatus();

            order.RemoveItem(item);
            
            Assert.IsFalse(order.Items.Contains(item));
        }

        [TestMethod]
        [ExpectedException(typeof(NotSupportedException))]
        public void Should_throw_notSupportedException_when_remove_an_item_from_a_delivered_order()
        {
            IOrder order = new Order();
            order.NextStatus();
            order.NextStatus();
            
            var item = new Item();
            order.RemoveItem(item);
        }
    }
}
