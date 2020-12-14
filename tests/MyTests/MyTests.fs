module SomeTests

open Expecto
open MyLibrary.Stuff

[<Tests>]
let tests =
    testList
        "Trivial tests to see whether test library setup is working"
        [

          testCase "Array containment" <| fun _ ->
            Expect.containsAll [| 2; 3; 4 |] [| 2; 4 |]
                "This is the case; {2,3,4} contains {2,4}"

          testCase "Use MyLibrary.Stuff" <| fun _ ->
            Expect.equal 9 (sq 3)
                "These should be equal"
        ]
