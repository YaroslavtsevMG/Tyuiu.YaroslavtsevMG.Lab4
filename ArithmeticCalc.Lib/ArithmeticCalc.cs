namespace ArithmeticCalc.Lib
{
    public static class ArithmeticCalc
    {
        public static double CalcExpression(string expression)
        {
            var postFixform = GetPostfixForm(expression);
            var stack = new Stack<double>();
            double number = 0;
            double x;
            foreach(var symbol in postFixform)
            {
                if(double.TryParse(symbol,out number))
                {
                    stack.Push(number);
                }
                else
                {
                    if(symbol=="-")
                    {
                        x = stack.Pop();
                        stack.Push(stack.Pop() - x);
                        continue;
                    }
                    if (symbol == "+")
                    {
                        
                        stack.Push(stack.Pop() + stack.Pop());
                        continue;
                    }
                    if (symbol == "*")
                    {
                        stack.Push(stack.Pop() * stack.Pop());
                        continue;
                    }
                    if (symbol == "/")
                    {
                        x = stack.Pop();
                        stack.Push(stack.Pop() / x);
                        continue;
                    }
                    if (symbol == "^")
                    {
                        x = stack.Pop();
                        stack.Push(Math.Pow(stack.Pop(), x));
                        continue;
                    }
                    if (symbol == "√")
                    {
                        stack.Push(Math.Pow(stack.Pop(), 1/stack.Pop()));
                        continue;
                    }
                    if (symbol == "cos")
                    {
                        stack.Push(Math.Cos(stack.Pop()));
                        continue;
                    }
                    if (symbol == "sin")
                    {
                        stack.Push(Math.Sin(stack.Pop()));
                        continue;
                    }
                    if (symbol == "log")
                    {
                        stack.Push(Math.Log(stack.Pop(), stack.Pop()));
                        continue;
                    }
                    if (symbol == "mod")
                    {
                        x = stack.Pop();
                        stack.Push(stack.Pop() % x);
                        continue;
                    }
                    if (symbol == "negative")
                    {
                        stack.Push(stack.Pop()*-1);
                        continue;
                    }
                    return 0;
                }
            }

            return stack.Pop();
        }
        public static List<string> GetPostfixForm(string expression)
        {
            Dictionary<string, int> priority = new Dictionary<string, int>()
            {
                {"(",-1 },
                {"-",0 },
                {"+",0 },
                {"*",1 },
                {"/",1 },
                {"^",2 },
                {"√",2 },
                {"sin",3 },
                {"cos",3 },
                {"log",3 },
                {"mod",3 },
                {"negative",4 }
            };
            var arr = new List<string>();
            string s = "";
            foreach(char i in expression)
            {
                if (i == ' ')
                {
                    arr.Add(s);
                    s = "";
                }
                else s = s + i;
            }
            arr.Add(s);
            
            var stack = new Stack<string>();
            var listres = new List<string>();
            var number = 0.0;
            foreach(string element in arr)
            {
                if(element=="")
                {
                    continue;
                }
                if(double.TryParse(element, out number))
                {
                    listres.Add(element);
                    continue;
                }
                if(element=="pi")
                {
                    listres.Add(Math.PI.ToString());
                    continue;
                }
                if (element == "exp")
                {
                    listres.Add(Math.Exp(1).ToString());
                    continue;
                }
                if (element=="(")
                {
                    stack.Push("(");
                    continue;
                }
                if(element==")")
                {
                    while(stack.Peek()!="(")
                    {
                        listres.Add(stack.Pop());
                    }
                    stack.Pop();
                    continue;
                }
                while(stack.Count!=0 && priority[element] <= priority[stack.Peek()])
                {
                    listres.Add(stack.Pop());
                }
                stack.Push(element);
            }
            while(stack.Count!=0)
            {
                listres.Add(stack.Pop());
            }
            return listres;
        }
    }
}
