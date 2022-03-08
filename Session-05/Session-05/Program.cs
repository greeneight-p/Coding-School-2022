using Session_05;

var req1 = new ActionRequest()
{
    Input = "asd",
    ActionType = ActionEnum.Convert
};


var resolver = new ActionResolver();

resolver.Execute(req1);


