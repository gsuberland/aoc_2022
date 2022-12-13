<Query Kind="Statements" />

string input = @"
[P]     [L]         [T]            
[L]     [M] [G]     [G]     [S]    
[M]     [Q] [W]     [H] [R] [G]    
[N]     [F] [M]     [D] [V] [R] [N]
[W]     [G] [Q] [P] [J] [F] [M] [C]
[V] [H] [B] [F] [H] [M] [B] [H] [B]
[B] [Q] [D] [T] [T] [B] [N] [L] [D]
[H] [M] [N] [Z] [M] [C] [M] [P] [P]
 1   2   3   4   5   6   7   8   9 

move 8 from 3 to 2
move 1 from 9 to 5
move 5 from 4 to 7
move 6 from 1 to 4
move 8 from 6 to 8
move 8 from 4 to 5
move 4 from 9 to 5
move 4 from 7 to 9
move 7 from 7 to 2
move 4 from 5 to 2
move 11 from 8 to 3
move 3 from 9 to 7
move 11 from 2 to 8
move 13 from 8 to 4
move 11 from 5 to 6
move 8 from 2 to 4
move 1 from 5 to 4
move 1 from 3 to 2
move 2 from 2 to 1
move 2 from 8 to 5
move 3 from 7 to 5
move 1 from 4 to 7
move 9 from 6 to 7
move 1 from 6 to 5
move 1 from 1 to 4
move 3 from 1 to 9
move 15 from 4 to 3
move 2 from 4 to 1
move 1 from 1 to 9
move 3 from 4 to 5
move 1 from 4 to 1
move 1 from 7 to 2
move 1 from 6 to 3
move 5 from 7 to 1
move 19 from 3 to 9
move 7 from 1 to 2
move 24 from 9 to 7
move 23 from 7 to 1
move 1 from 4 to 6
move 3 from 7 to 3
move 1 from 6 to 1
move 6 from 2 to 1
move 21 from 1 to 9
move 5 from 3 to 8
move 2 from 2 to 5
move 10 from 9 to 5
move 1 from 2 to 1
move 5 from 1 to 3
move 6 from 3 to 4
move 1 from 2 to 8
move 3 from 5 to 2
move 4 from 9 to 3
move 13 from 5 to 9
move 2 from 7 to 2
move 3 from 4 to 7
move 1 from 7 to 8
move 5 from 1 to 3
move 1 from 7 to 5
move 1 from 8 to 1
move 2 from 2 to 7
move 19 from 9 to 2
move 5 from 2 to 3
move 7 from 5 to 9
move 1 from 1 to 9
move 5 from 9 to 2
move 4 from 9 to 3
move 20 from 3 to 9
move 1 from 3 to 9
move 3 from 7 to 3
move 16 from 2 to 3
move 12 from 3 to 4
move 2 from 2 to 5
move 1 from 2 to 4
move 2 from 4 to 1
move 4 from 8 to 1
move 15 from 9 to 3
move 2 from 5 to 3
move 3 from 2 to 8
move 5 from 8 to 5
move 7 from 3 to 4
move 2 from 9 to 6
move 15 from 3 to 1
move 3 from 1 to 8
move 3 from 9 to 5
move 9 from 4 to 1
move 3 from 3 to 5
move 2 from 6 to 5
move 9 from 1 to 3
move 1 from 9 to 4
move 1 from 5 to 2
move 3 from 8 to 5
move 10 from 1 to 6
move 12 from 4 to 8
move 1 from 2 to 7
move 2 from 5 to 6
move 1 from 1 to 4
move 7 from 3 to 6
move 1 from 7 to 2
move 2 from 4 to 9
move 3 from 1 to 7
move 1 from 9 to 8
move 1 from 2 to 3
move 3 from 1 to 7
move 5 from 8 to 2
move 5 from 7 to 1
move 9 from 6 to 8
move 6 from 6 to 9
move 8 from 8 to 6
move 1 from 7 to 4
move 5 from 2 to 4
move 7 from 5 to 1
move 5 from 8 to 9
move 11 from 6 to 7
move 9 from 9 to 1
move 2 from 7 to 5
move 1 from 9 to 5
move 1 from 3 to 6
move 3 from 4 to 6
move 1 from 8 to 2
move 2 from 3 to 6
move 6 from 5 to 2
move 3 from 5 to 9
move 3 from 2 to 1
move 1 from 4 to 3
move 3 from 2 to 7
move 1 from 8 to 9
move 1 from 2 to 8
move 8 from 7 to 5
move 1 from 7 to 8
move 3 from 5 to 6
move 5 from 5 to 2
move 1 from 4 to 1
move 1 from 3 to 2
move 4 from 1 to 5
move 4 from 2 to 6
move 6 from 1 to 2
move 5 from 9 to 3
move 2 from 5 to 3
move 3 from 3 to 6
move 10 from 6 to 4
move 4 from 8 to 5
move 5 from 5 to 1
move 21 from 1 to 7
move 3 from 2 to 9
move 1 from 5 to 2
move 4 from 2 to 9
move 8 from 4 to 8
move 1 from 2 to 1
move 7 from 8 to 2
move 2 from 6 to 1
move 2 from 1 to 5
move 1 from 1 to 5
move 4 from 3 to 7
move 1 from 9 to 3
move 4 from 6 to 3
move 1 from 3 to 8
move 1 from 3 to 4
move 2 from 2 to 6
move 2 from 9 to 7
move 14 from 7 to 8
move 10 from 8 to 7
move 3 from 4 to 6
move 5 from 2 to 3
move 3 from 9 to 8
move 3 from 3 to 4
move 1 from 2 to 4
move 1 from 9 to 4
move 1 from 9 to 5
move 1 from 5 to 2
move 3 from 5 to 7
move 1 from 4 to 6
move 5 from 3 to 8
move 1 from 6 to 8
move 5 from 7 to 6
move 14 from 8 to 5
move 2 from 6 to 7
move 18 from 7 to 2
move 3 from 6 to 1
move 5 from 5 to 4
move 5 from 6 to 2
move 7 from 2 to 1
move 1 from 8 to 4
move 1 from 5 to 1
move 8 from 1 to 9
move 10 from 4 to 3
move 8 from 5 to 3
move 1 from 4 to 3
move 2 from 1 to 5
move 1 from 5 to 3
move 5 from 3 to 1
move 1 from 1 to 3
move 5 from 1 to 6
move 13 from 3 to 1
move 3 from 9 to 4
move 2 from 9 to 6
move 5 from 6 to 5
move 6 from 5 to 1
move 7 from 7 to 9
move 7 from 9 to 6
move 1 from 9 to 3
move 1 from 7 to 9
move 3 from 9 to 1
move 12 from 2 to 7
move 7 from 6 to 2
move 22 from 1 to 7
move 1 from 6 to 5
move 4 from 7 to 6
move 1 from 5 to 6
move 2 from 4 to 1
move 1 from 4 to 1
move 23 from 7 to 9
move 4 from 6 to 2
move 4 from 7 to 3
move 1 from 1 to 9
move 6 from 2 to 1
move 1 from 7 to 2
move 7 from 2 to 8
move 2 from 3 to 8
move 3 from 1 to 9
move 1 from 2 to 8
move 5 from 8 to 3
move 3 from 2 to 1
move 2 from 7 to 8
move 10 from 9 to 8
move 4 from 1 to 3
move 14 from 3 to 4
move 7 from 4 to 5
move 1 from 6 to 9
move 5 from 5 to 8
move 1 from 6 to 4
move 6 from 9 to 4
move 3 from 8 to 4
move 1 from 5 to 1
move 3 from 4 to 3
move 9 from 4 to 3
move 5 from 3 to 6
move 5 from 1 to 5
move 4 from 6 to 2
move 8 from 9 to 2
move 2 from 6 to 5
move 3 from 4 to 7
move 2 from 2 to 7
move 2 from 5 to 4
move 3 from 5 to 9
move 3 from 4 to 2
move 10 from 2 to 5
move 1 from 9 to 8
move 2 from 2 to 9
move 3 from 7 to 2
move 1 from 2 to 9
move 13 from 5 to 1
move 2 from 2 to 7
move 8 from 9 to 2
move 1 from 4 to 6
move 1 from 9 to 5
move 14 from 8 to 4
move 7 from 4 to 5
move 4 from 7 to 5
move 2 from 3 to 8
move 4 from 1 to 5
move 2 from 5 to 4
move 6 from 5 to 6
move 7 from 2 to 5
move 1 from 2 to 6
move 1 from 5 to 2
move 2 from 2 to 8
move 2 from 1 to 3
move 8 from 4 to 7
move 1 from 4 to 3
move 6 from 1 to 6
move 7 from 3 to 9
move 3 from 7 to 1
move 2 from 8 to 7
move 7 from 6 to 9
move 2 from 3 to 6
move 6 from 8 to 3
move 9 from 5 to 3
move 2 from 7 to 8
move 2 from 6 to 4
move 7 from 6 to 9
move 5 from 3 to 8
move 10 from 9 to 1
move 11 from 1 to 8
move 1 from 3 to 2
move 4 from 5 to 6
move 2 from 6 to 2
move 2 from 7 to 9
move 3 from 1 to 7
move 6 from 3 to 9
move 2 from 7 to 2
move 2 from 6 to 9
move 1 from 5 to 9
move 11 from 9 to 8
move 1 from 4 to 5
move 6 from 9 to 8
move 31 from 8 to 9
move 1 from 3 to 6
move 1 from 7 to 1
move 1 from 4 to 3
move 1 from 5 to 2
move 1 from 1 to 8
move 1 from 8 to 9
move 1 from 7 to 3
move 11 from 9 to 6
move 2 from 3 to 1
move 2 from 3 to 5
move 1 from 5 to 4
move 1 from 4 to 1
move 6 from 8 to 3
move 1 from 1 to 4
move 1 from 4 to 6
move 2 from 3 to 6
move 17 from 9 to 2
move 23 from 2 to 9
move 14 from 9 to 4
move 1 from 1 to 7
move 1 from 5 to 6
move 8 from 6 to 2
move 1 from 3 to 2
move 4 from 9 to 8
move 5 from 4 to 7
move 3 from 7 to 2
move 1 from 1 to 2
move 2 from 9 to 4
move 3 from 6 to 9
move 8 from 4 to 9
move 2 from 4 to 2
move 4 from 7 to 2
move 1 from 7 to 9
move 4 from 6 to 2
move 16 from 2 to 1
move 2 from 3 to 2
move 18 from 9 to 8
move 1 from 4 to 2
move 1 from 6 to 8
move 1 from 3 to 9
move 3 from 9 to 5
move 4 from 9 to 8
move 6 from 2 to 8
move 1 from 5 to 1
move 4 from 2 to 8
move 1 from 5 to 1
move 17 from 1 to 4
move 1 from 5 to 8
move 10 from 4 to 3
move 10 from 3 to 1
move 4 from 4 to 9
move 1 from 4 to 6
move 1 from 4 to 8
move 38 from 8 to 1
move 27 from 1 to 5
move 1 from 8 to 2
move 1 from 6 to 3
move 1 from 4 to 8
move 1 from 8 to 4
move 14 from 1 to 9
move 1 from 3 to 1
move 1 from 5 to 1
move 1 from 2 to 5
move 2 from 5 to 4
move 17 from 5 to 8
move 3 from 4 to 9
move 2 from 9 to 1
move 3 from 5 to 7
move 3 from 7 to 4
move 2 from 4 to 7
move 12 from 1 to 4
move 1 from 7 to 4
move 1 from 7 to 6
move 1 from 6 to 9
move 11 from 4 to 3
move 1 from 5 to 3
move 11 from 3 to 9
move 1 from 3 to 2
move 3 from 5 to 4
move 1 from 2 to 4
move 1 from 5 to 8
move 13 from 9 to 3
move 16 from 9 to 1
move 4 from 8 to 9
move 2 from 1 to 4
move 1 from 9 to 1
move 1 from 9 to 7
move 1 from 7 to 2
move 6 from 8 to 3
move 8 from 4 to 2
move 4 from 9 to 6
move 3 from 2 to 3
move 3 from 6 to 1
move 3 from 8 to 6
move 1 from 6 to 8
move 3 from 6 to 4
move 11 from 3 to 5
move 4 from 8 to 2
move 6 from 3 to 5
move 3 from 5 to 1
move 2 from 8 to 3
move 14 from 5 to 3
move 4 from 3 to 4
move 6 from 3 to 5
move 3 from 2 to 9
move 4 from 1 to 8
move 3 from 9 to 6
move 2 from 6 to 9
move 6 from 4 to 3
move 15 from 1 to 4
move 1 from 6 to 7
move 5 from 5 to 1
move 11 from 3 to 1
move 2 from 9 to 7
move 1 from 5 to 6
move 2 from 1 to 3
move 7 from 2 to 6
move 4 from 8 to 1
move 8 from 4 to 2
move 3 from 6 to 4
move 5 from 1 to 4
move 17 from 4 to 8
move 3 from 3 to 7
move 4 from 3 to 4
move 4 from 4 to 2
move 9 from 8 to 7
move 1 from 3 to 8
move 10 from 2 to 4
move 1 from 6 to 2
move 2 from 8 to 4
move 2 from 6 to 9
move 2 from 6 to 2
move 1 from 2 to 3
move 3 from 1 to 4
move 1 from 3 to 2
move 1 from 9 to 3
move 1 from 9 to 7
move 4 from 8 to 4
move 10 from 4 to 8
move 5 from 4 to 3
move 1 from 2 to 8
move 5 from 3 to 7
move 3 from 7 to 8
move 3 from 4 to 3
move 8 from 7 to 2
move 8 from 7 to 8
move 1 from 3 to 2
move 3 from 2 to 8
move 9 from 2 to 5
move 12 from 1 to 7
move 21 from 8 to 3
move 5 from 8 to 6
move 8 from 7 to 5
move 6 from 7 to 4
move 12 from 5 to 7
move 1 from 8 to 5
move 2 from 4 to 2
move 1 from 7 to 6
move 14 from 3 to 8
move 5 from 6 to 2
move 7 from 2 to 6
move 6 from 8 to 4
move 11 from 7 to 4
move 8 from 3 to 7
move 4 from 5 to 7
move 9 from 8 to 2
move 6 from 4 to 1
move 2 from 5 to 2
move 1 from 7 to 2
move 11 from 2 to 3
move 1 from 2 to 1
move 7 from 4 to 1
move 5 from 6 to 8
move 1 from 2 to 3
move 2 from 8 to 7
move 14 from 3 to 7
move 15 from 7 to 6
move 4 from 4 to 6
move 2 from 8 to 3
move 12 from 1 to 3
move 1 from 8 to 2
move 1 from 2 to 3
move 1 from 3 to 9
move 1 from 9 to 7
move 1 from 1 to 4
move 18 from 6 to 8
move 3 from 3 to 2
move 17 from 8 to 3
move 3 from 7 to 6
move 3 from 2 to 6
move 25 from 3 to 7
move 2 from 4 to 1
move 9 from 6 to 5
move 2 from 3 to 1
move 1 from 3 to 9
move 5 from 5 to 2
move 1 from 8 to 3
move 2 from 4 to 7
move 1 from 9 to 4
move 1 from 6 to 7
move 2 from 5 to 2
move 2 from 4 to 8
move 2 from 5 to 8
move 5 from 7 to 9
move 27 from 7 to 5
move 2 from 9 to 6";

// turn the crate map into an actual stack of items
var crateStacks = input
	// split into lines
	.Split("\r\n")
	// skip any blank lines at the start
	.SkipWhile(line => !line.StartsWith('['))
	// take all the lines that start with [
	.TakeWhile(line => line.StartsWith('['))
	// flip the map vertically, so the first crates in each stack are at the "top"
	.Reverse()
	// for each line, extract the crate values and positions
	.Select(
		line => 
			// take every 4n+1'th character in each line (corresponding to the letter positions)
			line.Where((c, i) => i % 4 == 1)
			// project that into an anonymous object with the value and position
			.Select((value, index) => new { value = value, positon = index + 1 })
			// ignore empty positions
			.Where(v => v.value != ' ')
	)
	// merge all the sets into one big list of crates and positions
	// importantly, the appearance of each crate is from bottom to top
	.SelectMany(crate => crate)
	// group crates by position
	.GroupBy(crate => crate.positon)
	// turn the groups into stacks
	.ToDictionary(
		crateGroup => crateGroup.Key,
		crateGroup => new Stack<char>(crateGroup.Select(v => v.value))
	);

var moveRegex = new Regex(@"^move\s+(?<count>[0-9]+)\s+from\s+(?<from>[0-9]+)\s+to\s+(?<to>[0-9]+)$");

// extract all the moves
var moves = input
	// split input into lines
	.Split("\r\n")
	// match each line with the regex
	.Select(line => moveRegex.Match(line))
	// skip lines that didn't match
	.Where(match => match.Success)
	// extract moves
	.Select(match => new {
		Count = int.Parse(match.Groups["count"].ValueSpan),
		From = int.Parse(match.Groups["from"].ValueSpan),
		To = int.Parse(match.Groups["to"].ValueSpan)
	});

// perform the moves
foreach (var move in moves)
{
	for (int n = 0; n < move.Count; n++)
		crateStacks[move.To].Push(crateStacks[move.From].Pop());
}

// make a new string from the top crate in each stack
new String(
	crateStacks.Select(
		stack => stack.Value.Peek()
	).ToArray()
).Dump();
