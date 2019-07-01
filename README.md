# Stackery Quickstart .NET/C#

This is a simple backend API for a list app, written in C#.

Follow the [Stackery Quickstart](https://docs.stackery.io/docs/quickstart/quickstart-dotnet/) to learn to use Stackery while writing this application.

The following are descriptions of the Stackery resources we'll be working with:

* ___Rest API___ : An API Gateway with GET and POST endpoints

* ___Function___ : Two Lambda functions will POST and GET items to and from the table

* ___Table___ : A DynamoDB table that will store our items

The application architecture is defined in the `template.yaml`, a Serverless Application Model (SAM) template which can be managed through the Stackery Dashboard at app.stackery.io.

Here is an overview of the files:

```bash
.
├── README.md                     <-- This README file
├── src                           <-- Source code dir for all AWS Lambda functions
│   ├── getItems                  <-- Source code dir for getItems function
│   │   ├── README.md             <-- Function-specific README
│   │   ├── Handler.cs            <-- Lambda function code
│   │   ├── StackeryFunction.csproj   <-- .Net dependencies
│   │   └── .stackery-config.yaml <-- Stackery function configuration file
│   ├── postItem                  <-- Source code dir for postItem function
│   │   ├── README.md             <-- Function-specific README
│   │   ├── Handler.cs            <-- Lambda function code
│   │   ├── StackeryFunction.csproj   <-- .Net dependencies
│   │   └──.stackery-config.yaml  <-- Stackery function configuration file
└── template.yaml                 <-- SAM infrastructure-as-code template
└──.stackery-config.yaml          <-- Stackery stack configuration file
```

