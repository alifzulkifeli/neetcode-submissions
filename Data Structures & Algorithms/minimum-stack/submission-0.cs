public class MinStack
{
    private Stack<int> _mainStack;
    private Stack<int> _minStack;
    public MinStack() {
        _mainStack =  new Stack<int>();
        _minStack = new Stack<int>();
    }
    
    public void Push(int val) {
        _mainStack.Push(val);
         if(_minStack.Count == 0 || _minStack.Peek() > val)
        {
            _minStack.Push(val);
        }
        else
        {
            _minStack.Push(_minStack.Peek());
        }
    }
    
    public void Pop()
    {
        _mainStack.Pop();
        _minStack.Pop();
    }
    
    public int Top()
    {
        return _mainStack.Peek();
    }
    
    public int GetMin()
    {
        return _minStack.Peek();
    }
    

}
