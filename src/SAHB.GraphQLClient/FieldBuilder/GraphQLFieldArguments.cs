﻿using System;
using SAHB.GraphQLClient.FieldBuilder.Attributes;

namespace SAHB.GraphQLClient.FieldBuilder
{
    // ReSharper disable once InconsistentNaming
    /// <summary>
    /// GraphQL argument used to contain metadata which can be used for generating a GraphQL query
    /// </summary>
    public class GraphQLFieldArguments
    {
        /// <summary>
        /// Initilizes a GraphQL argument used to contain metadata which can be used for generating a GraphQL query
        /// </summary>
        /// <param name="argument">The argument to initilize from</param>
        internal GraphQLFieldArguments(GraphQLArgumentsAttribute argument) 
            : this(argument.ArgumentName, argument.ArgumentType, argument.VariableName, argument.IsRequired)
        {
        }

        /// <summary>
        /// Initilizes a GraphQL argument used to contain metadata which can be used for generating a GraphQL query
        /// </summary>
        /// <param name="argumentName">GraphQL argument name</param>
        /// <param name="argumentType">GraphQL argument type of the variable</param>
        /// <param name="variableName">GraphQL variable name</param>
        public GraphQLFieldArguments(string argumentName, string argumentType, string variableName) 
            : this(argumentName: argumentName, argumentType: argumentType, variableName: variableName, isRequired: false)
        {
        }

        /// <summary>
        /// Initilizes a GraphQL argument used to contain metadata which can be used for generating a GraphQL query
        /// </summary>
        /// <param name="argumentName">GraphQL argument name</param>
        /// <param name="argumentType">GraphQL argument type of the variable</param>
        /// <param name="variableName">GraphQL variable name</param>
        /// <param name="isRequired">Is the GraphQL argument required to execute the query</param>
        public GraphQLFieldArguments(string argumentName, string argumentType, string variableName, bool isRequired)
            : this(argumentName: argumentName, argumentType: argumentType, variableName: variableName, isRequired: isRequired, inlineArgument: null)
        {
        }

        /// <summary>
        /// Initilizes a GraphQL argument used to contain metadata which can be used for generating a GraphQL query
        /// </summary>
        /// <param name="argumentName">GraphQL argument name</param>
        /// <param name="argumentType">GraphQL argument type of the variable</param>
        /// <param name="variableName">GraphQL variable name</param>
        /// <param name="isRequired">Is the GraphQL argument required to execute the query</param>
        /// <param name="inlineArgument">Should the GraphQL argument be inlined</param>
        public GraphQLFieldArguments(string argumentName, string argumentType, string variableName, bool isRequired, bool? inlineArgument)
        {
            ArgumentName = argumentName ?? throw new ArgumentNullException(nameof(argumentName));
            ArgumentType = argumentType ?? throw new ArgumentNullException(nameof(argumentType));
            VariableName = variableName ?? throw new ArgumentNullException(nameof(variableName));
            IsRequired = isRequired;
            InlineArgument = inlineArgument;
        }

        /// <summary>
        /// GraphQL argument name
        /// </summary>
        public string ArgumentName { get; }

        /// <summary>
        /// The argument type of the variable
        /// </summary>
        public string ArgumentType { get; }

        /// <summary>
        /// GraphQL variable name
        /// </summary>
        public string VariableName { get; set; }

        /// <summary>
        /// Is the argument required for execution of the query
        /// </summary>
        public bool IsRequired { get; set; }

        /// <summary>
        /// Should the argument be inlined
        /// </summary>
        public bool? InlineArgument { get; set; }

        /// <inheritdoc />
        public override string ToString()
        {
            return "Name: " + ArgumentName + " Type: " + ArgumentType + " IsRequired: " + IsRequired + " VariableName: " + (VariableName ?? "null");
        }
    }
}