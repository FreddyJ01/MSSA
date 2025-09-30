#!/bin/bash

# Repository Navigation Helper
# This script helps you quickly navigate to different sections of your reorganized MSSA repository

echo "🎓 MSSA Repository Structure"
echo "============================="
echo ""

echo "📁 Main Categories:"
echo "  📚 Coursework/     - Labs and assignments"
echo "  🧪 Demos/          - Learning demonstrations (categorized)"
echo "  🚀 Projects/       - Major projects and assignments"
echo "  📝 Notes/          - Study notes and references"
echo "  🔬 Sandbox/        - Experimental and scratch code"
echo ""

echo "🧪 Demo Categories:"
echo "  📋 Fundamentals/   - Basic C# concepts"
echo "  🔄 ControlFlow/    - Loops, conditionals, recursion"
echo "  📦 Collections/    - Data structures and collections"
echo "  🏗️  OOP/           - Object-oriented programming"
echo "  ⚡ AdvancedTopics/ - LINQ, async, extensions, APIs"
echo "  💾 IO/            - File operations and streams"
echo "  🧪 Testing/       - Debugging and error handling"
echo ""

echo "🔧 Quick Commands:"
echo "  Show demo structure:     find Demos -name '*.csproj' | sort"
echo "  List all projects:       find Projects -name '*.csproj' | sort"
echo "  Find a specific demo:    find Demos -name '*Demo*' -type d | grep <keyword>"
echo "  Run a demo:             cd Demos/<Category>/<DemoName> && dotnet run"
echo ""

echo "📊 Repository Stats:"
echo "  Total demos:    $(find Demos -name '*.csproj' | wc -l | tr -d ' ')"
echo "  Total projects: $(find Projects -name '*.csproj' | wc -l | tr -d ' ')"
echo "  Note files:     $(find Notes -name '*.md' | wc -l | tr -d ' ')"
echo ""

echo "💡 Tip: Use 'chmod +x navigate.sh && ./navigate.sh' to run this script"