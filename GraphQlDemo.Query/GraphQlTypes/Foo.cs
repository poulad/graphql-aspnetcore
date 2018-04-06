using GraphQL.Types;

namespace GraphQlDemo.Query.GraphQlTypes
{
    public class Foo
    {
        public string Bar { get; set; }
        public string[] Baz { get; set; }
    }

    public class FooType : ObjectGraphType<Foo>
    {
        public FooType()
        {
            Field(x => x.Bar);
            Field(x => x.Baz);
        }
    }

    public class FooInput : InputObjectGraphType<Foo>
    {
        public FooInput()
        {
            Field(x => x.Bar);
            Field(x => x.Baz);
        }
    }
    
    public class FooMutation : ObjectGraphType
    {
        public FooMutation()
        {
            Name = nameof(FooMutation);
            Field<FooType>(
                "addFoo",
                "Add a new foo",
                new QueryArguments(new QueryArgument<FooInput> {Name = "foo"})
            );
        }
    }
}