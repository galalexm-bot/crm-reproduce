using System.Collections.Generic;
using System.IO;
using System.Linq;
using EleWise.ELMA.CodeGeneration.CSharp.Enums;
using EleWise.ELMA.CodeGeneration.CSharp.Nodes;
using EleWise.ELMA.CodeGeneration.CSharp.Trivias;

namespace EleWise.ELMA.CodeGeneration.CSharp;

public class SyntaxGenerator
{
	private NullLiteralExpressionSyntax _nullLiteralExpression;

	private ThisExpressionSyntax _thisExpression;

	private BaseExpression _baseExpression;

	private TrueLiteralExpression _trueLiteralExpression;

	private FalseLiteralExpressionSyntax _falseLiteralExpression;

	internal static string GenerateInternal(IEnumerable<SyntaxNode> declarations, string indentation, string eol)
	{
		using StringWriter stringWriter = new StringWriter();
		stringWriter.NewLine = eol;
		GenerateInternal(declarations, stringWriter, indentation);
		return stringWriter.ToString();
	}

	internal static bool NotNewLineSeparated(SyntaxNode declaration)
	{
		if (!(declaration is NamespaceImportDeclarationSyntax))
		{
			return declaration is AttributeSyntax;
		}
		return true;
	}

	internal static bool NewLineSeparated(SyntaxNode declaration)
	{
		return !NotNewLineSeparated(declaration);
	}

	internal static void GenerateInternal(IEnumerable<SyntaxNode> declarations, TextWriter writer, string indentation)
	{
		using GenerationContext generationContext = new GenerationContext(writer, indentation);
		declarations = declarations.ToArray();
		generationContext.Write(declarations.Where(NotNewLineSeparated)).If(declarations.Any(NotNewLineSeparated) && declarations.Any(NewLineSeparated), delegate(GenerationContext c)
		{
			c.WriteLine();
		}).WriteNewLineSeparated(declarations.Where(NewLineSeparated));
	}

	public void Generate(IEnumerable<SyntaxNode> declarations, TextWriter writer, string indentation = "    ")
	{
		GenerateInternal(declarations, writer, indentation);
	}

	public string Generate(IEnumerable<SyntaxNode> declarations, string indentation = "    ", string eol = "\r\n")
	{
		return GenerateInternal(declarations, indentation, eol);
	}

	public SyntaxTrivia Comment(string text)
	{
		return new CommentSyntaxTrivia(text);
	}

	public SyntaxTrivia PragmaWarningDisableDirectiveTrivia(IEnumerable<SyntaxNode> errorCodes)
	{
		return new PragmaWarningDirectiveTrivia(disable: true, errorCodes.CastOrNull<ExpressionSyntax>());
	}

	public SyntaxTrivia PragmaWarningRestoreDirectiveTrivia(IEnumerable<SyntaxNode> errorCodes)
	{
		return new PragmaWarningDirectiveTrivia(disable: false, errorCodes.CastOrNull<ExpressionSyntax>());
	}

	public SyntaxNode ParseTypeName(string typeName)
	{
		return EleWise.ELMA.CodeGeneration.CSharp.Nodes.TypeSyntax.ParseTypeName(typeName);
	}

	public SyntaxNode TypeSyntax(string genericTypeName, IEnumerable<SyntaxNode> typeArguments)
	{
		return new TypeSyntax((IdentifierNameSyntax)((typeArguments != null) ? GenericName(genericTypeName, typeArguments) : IdentifierName(genericTypeName)));
	}

	public SyntaxNode LiteralExpression(object value)
	{
		return new LiteralExpressionSyntax(value);
	}

	public SyntaxNode IdentifierName(string identifier)
	{
		return new IdentifierNameSyntax(identifier);
	}

	public SyntaxNode GenericName(string identifier, IEnumerable<SyntaxNode> typeArguments)
	{
		return new GenericNameSyntax(identifier, typeArguments.CastOrNull<TypeSyntax>());
	}

	public SyntaxNode NullLiteralExpression()
	{
		return _nullLiteralExpression ?? (_nullLiteralExpression = new NullLiteralExpressionSyntax());
	}

	public SyntaxNode ThisExpression()
	{
		return _thisExpression ?? (_thisExpression = new ThisExpressionSyntax());
	}

	public SyntaxNode BaseExpression()
	{
		return _baseExpression ?? (_baseExpression = new BaseExpression());
	}

	public SyntaxNode TrueLiteralExpression()
	{
		return _trueLiteralExpression ?? (_trueLiteralExpression = new TrueLiteralExpression());
	}

	public SyntaxNode FalseLiteralExpression()
	{
		return _falseLiteralExpression ?? (_falseLiteralExpression = new FalseLiteralExpressionSyntax());
	}

	public SyntaxNode ArrayTypeExpression(SyntaxNode elementType)
	{
		return new ArrayTypeExpression((TypeSyntax)elementType);
	}

	public SyntaxNode TypeOfExpression(SyntaxNode type)
	{
		return new TypeOfExpressionSyntax((type as TypeSyntax) ?? new TypeSyntax((IdentifierNameSyntax)type));
	}

	public SyntaxNode DefaultExpression(SyntaxNode type)
	{
		return new DefaultExpressionSyntax((type as TypeSyntax) ?? new TypeSyntax((IdentifierNameSyntax)type));
	}

	public SyntaxNode AttributeArgument(SyntaxNode expression)
	{
		return new AttributeArgumentSyntax((ExpressionSyntax)expression);
	}

	public SyntaxNode AttributeArgument(string name, SyntaxNode expression)
	{
		return new AttributeArgumentSyntax(name, (ExpressionSyntax)expression);
	}

	public SyntaxNode Attribute(string attributeTypeName, IEnumerable<SyntaxNode> args)
	{
		return new AttributeSyntax(attributeTypeName, args?.Select((SyntaxNode a) => (a as AttributeArgumentSyntax) ?? ((AttributeArgumentSyntax)AttributeArgument(a))));
	}

	public SyntaxNode AddAttributes(SyntaxNode syntaxNode, IEnumerable<SyntaxNode> attributes)
	{
		syntaxNode.AddAttributes(attributes.CastOrNull<AttributeSyntax>());
		return syntaxNode;
	}

	public SyntaxNode NamespaceDeclaration(string name, IEnumerable<SyntaxNode> declarations)
	{
		return new NamespaceDeclarationSyntax(name, declarations.CastOrNull<MemberSyntax>());
	}

	public SyntaxNode NamespaceImportDeclaration(string name)
	{
		return new NamespaceImportDeclarationSyntax(name);
	}

	public SyntaxNode ClassDeclaration(string name, IEnumerable<string> typeParameters, Accessibility accessibility = Accessibility.NotApplicable, DeclarationModifiers modifiers = DeclarationModifiers.None, SyntaxNode baseType = null, IEnumerable<SyntaxNode> interfaceTypes = null, IEnumerable<SyntaxNode> members = null)
	{
		return new ClassDeclarationSyntax(name, typeParameters, accessibility, modifiers, (TypeSyntax)baseType, interfaceTypes.CastOrNull<TypeSyntax>(), members.CastOrNull<MemberSyntax>());
	}

	public SyntaxNode InterfaceDeclaration(string name, IEnumerable<string> typeParameters, Accessibility accessibility = Accessibility.NotApplicable, DeclarationModifiers modifiers = DeclarationModifiers.None, IEnumerable<SyntaxNode> interfaceTypes = null, IEnumerable<SyntaxNode> members = null)
	{
		return new InterfaceDeclarationSyntax(name, typeParameters, accessibility, modifiers, interfaceTypes.CastOrNull<TypeSyntax>(), members.CastOrNull<MemberSyntax>());
	}

	public SyntaxNode EnumMember(string name, SyntaxNode expression)
	{
		return new EnumMemberSyntax(name, (ExpressionSyntax)expression);
	}

	public SyntaxNode EnumDeclaration(string name, Accessibility accessibility = Accessibility.NotApplicable, DeclarationModifiers modifiers = DeclarationModifiers.None, IEnumerable<SyntaxNode> members = null)
	{
		return new EnumDeclarationSyntax(name, accessibility, modifiers, members.CastOrNull<EnumMemberSyntax>());
	}

	public SyntaxNode ParameterDeclaration(string name, SyntaxNode type, SyntaxNode initializer = null, RefKind refKind = RefKind.None)
	{
		return new ParameterDeclarationSyntax(name, type, initializer, refKind);
	}

	public SyntaxNode ConstructorDeclaration(IEnumerable<SyntaxNode> parameters, Accessibility accessibility = Accessibility.NotApplicable, DeclarationModifiers modifiers = DeclarationModifiers.None, IEnumerable<SyntaxNode> baseConstructorArguments = null, IEnumerable<SyntaxNode> statements = null)
	{
		return new ConstructorDeclarationSyntax(parameters.CastOrNull<ParameterDeclarationSyntax>(), accessibility, modifiers, baseConstructorArguments.CastOrNull<ExpressionSyntax>(), null, statements.CastOrNull<StatementSyntax>());
	}

	public SyntaxNode ThisConstructorDeclaration(IEnumerable<SyntaxNode> parameters, Accessibility accessibility = Accessibility.NotApplicable, DeclarationModifiers modifiers = DeclarationModifiers.None, IEnumerable<SyntaxNode> thisConstructorArguments = null, IEnumerable<SyntaxNode> statements = null)
	{
		return new ConstructorDeclarationSyntax(parameters.CastOrNull<ParameterDeclarationSyntax>(), accessibility, modifiers, null, thisConstructorArguments.CastOrNull<ExpressionSyntax>(), statements.CastOrNull<StatementSyntax>());
	}

	public SyntaxNode AutoPropertyDeclaration(string name, SyntaxNode type, Accessibility accessibility = Accessibility.NotApplicable, DeclarationModifiers modifiers = DeclarationModifiers.None, Accessibility getterAccessibility = Accessibility.NotApplicable, Accessibility setterAccessibility = Accessibility.NotApplicable)
	{
		return new PropertyDeclarationSyntax(name, (TypeSyntax)type, accessibility, modifiers, null, null, getterAccessibility, setterAccessibility);
	}

	public SyntaxNode PropertyDeclaration(string name, SyntaxNode type, Accessibility accessibility = Accessibility.NotApplicable, DeclarationModifiers modifiers = DeclarationModifiers.None, IEnumerable<SyntaxNode> getAccessorStatements = null, IEnumerable<SyntaxNode> setAccessorStatements = null, Accessibility getterAccessibility = Accessibility.NotApplicable, Accessibility setterAccessibility = Accessibility.NotApplicable)
	{
		return new PropertyDeclarationSyntax(name, (TypeSyntax)type, accessibility, modifiers, getAccessorStatements.CastOrNull<StatementSyntax>(), setAccessorStatements.CastOrNull<StatementSyntax>(), getterAccessibility, setterAccessibility);
	}

	public SyntaxNode MethodDeclaration(string name, IEnumerable<SyntaxNode> parameters = null, IEnumerable<string> typeParameters = null, SyntaxNode returnType = null, Accessibility accessibility = Accessibility.NotApplicable, DeclarationModifiers modifiers = DeclarationModifiers.None, IEnumerable<SyntaxNode> statements = null)
	{
		return new MethodDeclarationSyntax(name, parameters.CastOrNull<ParameterDeclarationSyntax>(), typeParameters, (TypeSyntax)returnType, accessibility, modifiers, statements.CastOrNull<StatementSyntax>());
	}

	public SyntaxNode FieldDeclaration(string name, SyntaxNode type, Accessibility accessibility = Accessibility.NotApplicable, DeclarationModifiers modifiers = DeclarationModifiers.None, SyntaxNode initializer = null)
	{
		return new FieldDeclarationSyntax(name, (TypeSyntax)type, accessibility, modifiers, (ExpressionSyntax)initializer);
	}

	public SyntaxNode AsPrivateInterfaceImplementation(SyntaxNode declaration, SyntaxNode interfaceType)
	{
		((InterfaceMemberSyntax)declaration).PrivateInterfaceImplementationType = (TypeSyntax)interfaceType;
		return declaration;
	}

	public SyntaxNode ReturnStatement(SyntaxNode expression)
	{
		return new ReturnStatementSyntax((ExpressionSyntax)expression);
	}

	public SyntaxNode AssignmentStatement(SyntaxNode left, SyntaxNode right)
	{
		return new AssignmentExpressionSyntax((ExpressionSyntax)left, (ExpressionSyntax)right);
	}

	public SyntaxNode ExpressionStatement(SyntaxNode expression)
	{
		return new ExpressionStatementSyntax((ExpressionSyntax)expression);
	}

	public SyntaxNode LocalDeclarationStatement(string identifier, SyntaxNode initializer)
	{
		return new LocalDeclarationStatementSyntax(identifier, (ExpressionSyntax)initializer);
	}

	public SyntaxNode LocalDeclarationStatement(SyntaxNode type, string identifier, SyntaxNode initializer = null, bool isConst = false)
	{
		return new LocalDeclarationStatementSyntax((TypeSyntax)type, identifier, (ExpressionSyntax)initializer, isConst);
	}

	public SyntaxNode IfStatement(SyntaxNode condition, IEnumerable<SyntaxNode> trueStatements, IEnumerable<SyntaxNode> falseStatements = null)
	{
		return new IfStatementSyntax((ExpressionSyntax)condition, trueStatements.CastOrNull<StatementSyntax>(), falseStatements.CastOrNull<StatementSyntax>());
	}

	public SyntaxNode SwitchStatement(SyntaxNode identifier, IEnumerable<SyntaxNode> caseStatements)
	{
		return new SwitchStatementSyntax((IdentifierNameSyntax)identifier, caseStatements.CastOrNull<CaseStatementSyntax>());
	}

	public SyntaxNode CaseStatement(SyntaxNode value, IEnumerable<SyntaxNode> statements)
	{
		return new CaseStatementSyntax((ExpressionSyntax)value, statements.CastOrNull<StatementSyntax>());
	}

	public SyntaxNode BreakStatement()
	{
		return new BreakStatementSyntax();
	}

	public SyntaxNode ThrowStatement(SyntaxNode expression = null)
	{
		return new ThrowStatementSyntax((ExpressionSyntax)expression);
	}

	public SyntaxNode SnippetExpression(string text)
	{
		return new SnippetExpressionSyntax(text);
	}

	public SyntaxNode CastExpression(SyntaxNode type, SyntaxNode expression)
	{
		return new CastExpressionSyntax((TypeSyntax)type, (ExpressionSyntax)expression);
	}

	public SyntaxNode TryCastExpression(SyntaxNode expression, SyntaxNode type)
	{
		return new TryCastExpressionSyntax((TypeSyntax)type, (ExpressionSyntax)expression);
	}

	public SyntaxNode InvocationExpression(SyntaxNode expression, IEnumerable<SyntaxNode> arguments)
	{
		return new InvocationExpressionSyntax((ExpressionSyntax)expression, arguments.CastOrNull<ExpressionSyntax>());
	}

	public SyntaxNode RefKindArgument(RefKind refKind, SyntaxNode expression)
	{
		return new RefKindArgumentSyntax(refKind, (ExpressionSyntax)expression);
	}

	public SyntaxNode ObjectCreationExpression(SyntaxNode type, IEnumerable<SyntaxNode> arguments, IEnumerable<SyntaxNode> parameters)
	{
		return new ObjectCreationExpressionSyntax((TypeSyntax)type, arguments.CastOrNull<ExpressionSyntax>(), parameters.CastOrNull<ExpressionSyntax>());
	}

	public SyntaxNode MemberAccessExpression(SyntaxNode expression, SyntaxNode memberName)
	{
		return new MemberAccessExpressionSyntax((ExpressionSyntax)expression, memberName);
	}

	public SyntaxNode MemberAccessExpression(SyntaxNode expression, string memberName)
	{
		return new MemberAccessExpressionSyntax((ExpressionSyntax)expression, memberName);
	}

	public SyntaxNode ConditionalAccessExpression(SyntaxNode expression, SyntaxNode memberName)
	{
		return new ConditionalAccessExpressionSyntax((ExpressionSyntax)expression, memberName);
	}

	public SyntaxNode ConditionalAccessExpression(SyntaxNode expression, string memberName)
	{
		return new ConditionalAccessExpressionSyntax((ExpressionSyntax)expression, memberName);
	}

	public SyntaxNode ConditionalExpression(SyntaxNode condition, SyntaxNode trueExpression, SyntaxNode falseExpression)
	{
		return new ConditionalExpressionSyntax((ExpressionSyntax)condition, (ExpressionSyntax)trueExpression, (ExpressionSyntax)falseExpression);
	}

	public SyntaxNode CoalesceExpression(SyntaxNode left, SyntaxNode right)
	{
		return new CoalesceExpressionSyntax((ExpressionSyntax)left, (ExpressionSyntax)right);
	}

	public SyntaxNode ElementAccessExpression(SyntaxNode expression, IEnumerable<SyntaxNode> arguments)
	{
		return new ElementAccessExpressionSyntax((ExpressionSyntax)expression, arguments.CastOrNull<ExpressionSyntax>());
	}

	public SyntaxNode LambdaParameter(string identifier, SyntaxNode type = null)
	{
		return new LambdaParameterSyntax(identifier, (TypeSyntax)type);
	}

	public SyntaxNode ValueReturningLambdaExpression(IEnumerable<SyntaxNode> statements)
	{
		return ValueReturningLambdaExpression((IEnumerable<SyntaxNode>)null, statements);
	}

	public SyntaxNode ValueReturningLambdaExpression(SyntaxNode expression)
	{
		return ValueReturningLambdaExpression((IEnumerable<SyntaxNode>)null, expression);
	}

	public SyntaxNode ValueReturningLambdaExpression(string parameterName, SyntaxNode expression)
	{
		return ValueReturningLambdaExpression(new SyntaxNode[1] { LambdaParameter(parameterName) }, expression);
	}

	public SyntaxNode ValueReturningLambdaExpression(string parameterName, IEnumerable<SyntaxNode> statements)
	{
		return ValueReturningLambdaExpression(new SyntaxNode[1] { LambdaParameter(parameterName) }, statements);
	}

	public SyntaxNode ValueReturningLambdaExpression(IEnumerable<SyntaxNode> lambdaParameters, SyntaxNode expression)
	{
		return new LambdaExpressionSyntax(lambdaParameters.CastOrNull<LambdaParameterSyntax>(), (ExpressionSyntax)expression);
	}

	public SyntaxNode ValueReturningLambdaExpression(IEnumerable<SyntaxNode> lambdaParameters, IEnumerable<SyntaxNode> statements)
	{
		return new LambdaExpressionSyntax(lambdaParameters.CastOrNull<LambdaParameterSyntax>(), statements.CastOrNull<StatementSyntax>());
	}

	public SyntaxNode VoidReturningLambdaExpression(IEnumerable<SyntaxNode> statements)
	{
		return VoidReturningLambdaExpression((IEnumerable<SyntaxNode>)null, statements);
	}

	public SyntaxNode VoidReturningLambdaExpression(SyntaxNode expression)
	{
		return VoidReturningLambdaExpression((IEnumerable<SyntaxNode>)null, expression);
	}

	public SyntaxNode VoidReturningLambdaExpression(string parameterName, SyntaxNode expression)
	{
		return VoidReturningLambdaExpression(new SyntaxNode[1] { LambdaParameter(parameterName) }, expression);
	}

	public SyntaxNode VoidReturningLambdaExpression(string parameterName, IEnumerable<SyntaxNode> statements)
	{
		return VoidReturningLambdaExpression(new SyntaxNode[1] { LambdaParameter(parameterName) }, statements);
	}

	public SyntaxNode VoidReturningLambdaExpression(IEnumerable<SyntaxNode> lambdaParameters, SyntaxNode expression)
	{
		return new LambdaExpressionSyntax(lambdaParameters.CastOrNull<LambdaParameterSyntax>(), (ExpressionSyntax)expression);
	}

	public SyntaxNode VoidReturningLambdaExpression(IEnumerable<SyntaxNode> lambdaParameters, IEnumerable<SyntaxNode> statements)
	{
		return new LambdaExpressionSyntax(lambdaParameters.CastOrNull<LambdaParameterSyntax>(), statements.CastOrNull<StatementSyntax>());
	}

	public SyntaxNode ValueEqualsExpression(SyntaxNode left, SyntaxNode right)
	{
		return new BinaryExpressionSyntax(ExpressionSyntaxPriority.ValueEquals, (ExpressionSyntax)left, (ExpressionSyntax)right);
	}

	public SyntaxNode ValueNotEqualsExpression(SyntaxNode left, SyntaxNode right)
	{
		return new BinaryExpressionSyntax(ExpressionSyntaxPriority.ValueNotEquals, (ExpressionSyntax)left, (ExpressionSyntax)right);
	}

	public SyntaxNode LogicalOrExpression(SyntaxNode left, SyntaxNode right)
	{
		return new BinaryExpressionSyntax(ExpressionSyntaxPriority.LogicalOr, (ExpressionSyntax)left, (ExpressionSyntax)right);
	}

	public SyntaxNode LogicalAndExpression(SyntaxNode left, SyntaxNode right)
	{
		return new BinaryExpressionSyntax(ExpressionSyntaxPriority.LogicalAnd, (ExpressionSyntax)left, (ExpressionSyntax)right);
	}

	public SyntaxNode AddExpression(SyntaxNode left, SyntaxNode right)
	{
		return new BinaryExpressionSyntax(ExpressionSyntaxPriority.Add, (ExpressionSyntax)left, (ExpressionSyntax)right);
	}

	public SyntaxNode SubtractExpression(SyntaxNode left, SyntaxNode right)
	{
		return new BinaryExpressionSyntax(ExpressionSyntaxPriority.Subtract, (ExpressionSyntax)left, (ExpressionSyntax)right);
	}

	public SyntaxNode MultiplyExpression(SyntaxNode left, SyntaxNode right)
	{
		return new BinaryExpressionSyntax(ExpressionSyntaxPriority.Multiply, (ExpressionSyntax)left, (ExpressionSyntax)right);
	}

	public SyntaxNode DivideExpression(SyntaxNode left, SyntaxNode right)
	{
		return new BinaryExpressionSyntax(ExpressionSyntaxPriority.Divide, (ExpressionSyntax)left, (ExpressionSyntax)right);
	}

	public SyntaxNode AwaitExpression(SyntaxNode expression)
	{
		return new AwaitExpressionSyntax((ExpressionSyntax)expression);
	}

	public SyntaxNode WithTypeConstraint(SyntaxNode declaration, string typeParameterName, SpecialTypeConstraintKind kinds, IEnumerable<SyntaxNode> types = null)
	{
		declaration.WithTypeConstraint(typeParameterName, kinds, types.CastOrNull<TypeSyntax>());
		return declaration;
	}
}
