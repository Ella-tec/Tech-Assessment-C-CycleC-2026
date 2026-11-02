Your task is to simulate a real-world API call using the JSONPlaceholder API. You will:
Connect to this endpoint: https://jsonplaceholder.typicode.com/posts
Make a GET request to retrieve data
Parse the JSON response and extract the field: “title”
Add Error Handling (e.g., console.log / Console.WriteLine)
Store your API base URL in an `.env` file and ensure `.gitignore` excludes it
For submission commit and push the Task 3 files (Task 3.cs + .env + .gitignore).
---
What was fixed / completed in this corrected version
.env file – Previously empty (`API_BASE_URL=`).  
Now correctly contains:  
`API_BASE_URL=https://jsonplaceholder.typicode.com/posts`
.gitignore – Previously empty.  
Now properly ignores `.env` so secrets / local config are never committed.
Task 3.cs improvements:
Robust error handling (HTTP status, network, timeout, JSON parse, missing env var)
Safer .env loading (tries multiple common paths)
Validates that the response is a non-empty array
Extracts and displays the `title` field of the posts
Clear console messages
Note: The original README mentioned “task3.js”, but the provided starter code is C#. The corrected solution stays in C# to match the given starter file.