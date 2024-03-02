using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        class dynamicArray<T>
        {
            T[] array;
            int capacity = 1;
            int lenght = 0;
            public dynamicArray()
            {
                array = new T[capacity];
            }
            public void resize()
            {
                T[] newArray = new T[capacity * 2];
                for (int i = 0; i < capacity; i++)
                {
                    newArray[i] = array[i];
                }
                capacity *= 2;
                array = newArray;
            }
            public void push_back(T element)
            {
                if (lenght >= capacity)
                {
                    resize();
                }
                array[lenght] = element;
                lenght++;
            }
            public T pop_back()
            {
                return array[--lenght];
            }
            public int size()
            {
                return lenght;
            }
            public int Capacity()
            {
                return capacity;
            }
            public T getItem(int index)
            {
                return array[index];
            }

        }
        class Stack<T>
        {
            dynamicArray<T> array = new dynamicArray<T>();
            public void push(T element)
            {
                array.push_back(element);
            }
            public void pop()
            {
                array.pop_back();
            }
            public T top()
            {
                return array.getItem(array.size() - 1);
            }
            public bool is_empty()
            {
                return array.size() == 0 ? true : false;
            }
        }
        class Queue<T>
        {
            Stack<T> stack1 = new Stack<T>();
            Stack<T> stack2 = new Stack<T>();
            public void push(T element)
            {
                stack1.push(element);
            }
            public T pop()
            {
                if (stack2.is_empty())
                {
                    while (!stack1.is_empty())
                    {
                        stack2.push(stack1.top());
                        stack1.pop();
                    }
                    T element = stack2.top();
                    stack2.pop();
                    return element;
                }
                else
                {
                    T element = stack2.top();
                    stack2.pop();
                    return element;
                }
            }
            public T top()
            {
                return stack1.top();
            }
            public bool is_empty()
            {
                return stack1.is_empty() && stack2.is_empty() ? true : false;
            }


        }
        static int Sum(int a, int b) { return a + b; }
        public static bool validBraces(string braces)
        {
            var stack = new Stack<char>();
            foreach (var c in braces)
                switch (c)
                {
                    case '(':
                    case '[':
                    case '{':
                        stack.push(c);
                        continue;
                    case ')':
                        if (stack.is_empty() || stack.top() != '(') return false;
                        stack.pop();
                        continue;
                    case ']':
                        if (stack.is_empty() || stack.top() != '[') return false;
                        stack.pop();
                        continue;
                    case '}':
                        if (stack.is_empty() || stack.top() != '{') return false;
                        stack.pop();
                        continue;
                }
            return stack.is_empty();
        }
    }
}