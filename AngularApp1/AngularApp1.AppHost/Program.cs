var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.AngularApp1_Server>("angularapp1-server");

builder.Build().Run();
