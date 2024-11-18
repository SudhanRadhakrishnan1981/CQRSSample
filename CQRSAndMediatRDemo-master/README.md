# CQRSAndMediatRDemo
﻿CQRS with MediatR

		CQRS
********************
using CQRS - Command and Query Responsibility Segregation we can separate write operations (commands)
             and the read operations (queries) into separate models in an application.
CQRS is to improve the scalability and performance of an application by separating the read and write operations into different models, 
each optimized for their specific task.

This can lead to a more flexible and maintainable application architecture, especially in enterprise level large-scale applications 
with high read and write loads.

		MediatR
***********************
Helps to implement the Mediator pattern and MediatR can be used as a useful tool to implement CQRS in a .NET application.
MediatR pattern helps to reduce direct dependency between multiple objects and make them collaborative through MediatR.
