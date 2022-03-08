using Session_05;

var req1 = new ActionRequest()
{
    Input = "asd",
    ActionType = ActionEnum.Convert
};

var req2 = new ActionRequest()
{
    Input = "6",
    ActionType = ActionEnum.Convert
};

var req3 = new ActionRequest()
{
    Input = "9",
    ActionType = ActionEnum.Convert
};


var req4 = new ActionRequest()
{
    Input = "John",
    ActionType = ActionEnum.Reverse
};


var req5 = new ActionRequest()
{
    Input = "A month has 4 weeks and a week has 7 days",
    ActionType = ActionEnum.Uppercase
};




var logger = new MessageLogger();
var resolver = new ActionResolver(logger);
resolver.Execute(req1);
resolver.Execute(req2);
resolver.Execute(req3);

resolver.Execute(req4);

resolver.Execute(req5);

logger.ReadAll();


