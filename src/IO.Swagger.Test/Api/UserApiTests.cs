/* 
 * Swagger Petstore - OpenAPI 3.0
 *
 * This is a sample Pet Store Server based on the OpenAPI 3.0 specification.  You can find out more about Swagger at [http://swagger.io](http://swagger.io). In the third iteration of the pet store, we've switched to the design first approach! You can now help us improve the API whether it's by making changes to the definition itself or to the code. That way, with time, we can improve the API in general, and expose some of the new features in OAS3.  Some useful links: - [The Pet Store repository](https://github.com/swagger-api/swagger-petstore) - [The source API definition for the Pet Store](https://github.com/swagger-api/swagger-petstore/blob/master/src/main/resources/openapi.yaml)
 *
 * OpenAPI spec version: 1.0.19
 * Contact: apiteam@swagger.io
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing UserApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class UserApiTests
    {
        private UserApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new UserApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of UserApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' UserApi
            //Assert.IsInstanceOfType(typeof(UserApi), instance, "instance is a UserApi");
        }

        /// <summary>
        /// Test CreateUser
        /// </summary>
        [Test]
        public void CreateUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //User body = null;
            //var response = instance.CreateUser(body);
            //Assert.IsInstanceOf<User> (response, "response is User");
        }
        /// <summary>
        /// Test CreateUsersWithListInput
        /// </summary>
        [Test]
        public void CreateUsersWithListInputTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<User> body = null;
            //var response = instance.CreateUsersWithListInput(body);
            //Assert.IsInstanceOf<User> (response, "response is User");
        }
        /// <summary>
        /// Test DeleteUser
        /// </summary>
        [Test]
        public void DeleteUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //instance.DeleteUser(username);
            
        }
        /// <summary>
        /// Test GetUserByName
        /// </summary>
        [Test]
        public void GetUserByNameTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //var response = instance.GetUserByName(username);
            //Assert.IsInstanceOf<User> (response, "response is User");
        }
        /// <summary>
        /// Test LoginUser
        /// </summary>
        [Test]
        public void LoginUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //string password = null;
            //var response = instance.LoginUser(username, password);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        /// <summary>
        /// Test LogoutUser
        /// </summary>
        [Test]
        public void LogoutUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.LogoutUser();
            
        }
        /// <summary>
        /// Test UpdateUser
        /// </summary>
        [Test]
        public void UpdateUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //User body = null;
            //instance.UpdateUser(username, body);
            
        }
    }

}
