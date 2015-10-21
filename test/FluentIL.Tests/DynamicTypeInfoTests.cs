﻿using System;
using FluentIL.Infos;
using NUnit.Framework;
using SharpTestsEx;

namespace FluentIL.Tests
{
    [TestFixture]
    class DynamicTypeInfoTests
    {
        [Test]
        public void AsType_ReturnsTypeWithSpecifiedName()
        {
            // arrange
            var dt = new DynamicTypeInfo("Foo");
            // act
            var t = dt.AsType;
            // assert
            t.Name.Should().Be("Foo");
        }

        [Test]
        public void AsType_ReturnedTypeShouldBeInstantiableViaActivatorCreateInstance()
        {
            // arrange
            var dt = new DynamicTypeInfo("Foo");
            // act
            var t = dt.AsType;
            var obj = Activator.CreateInstance(t);
            // assert
            obj.GetType().Should().Be(t);
        }

        [Test]
        public void TypeBuilder_InvokedTwoTimes_ReturnsSameValue()
        {
            // arrange
            var dt = new DynamicTypeInfo("Foo");
            // act
            var t1 = dt.TypeBuilder;
            var t2 = dt.TypeBuilder;
            // assert
            t1.Should().Be(t2);
        }
    }
}
