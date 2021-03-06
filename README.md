# BankingWebApi

Enhanced Banking App

Account types:
	Checking
	Savings
	Credit Card
	CDs

Functions
	Deposit
	Interest
	Withdrawal
	Transfar

Notes:
-Needs a customer to tie accounts to
-Bank statements need transaction history, table that keeps track of everything you do
	-Every single account needs this
	-on this datetime you made this action
-Credit Cards: something like paying interest but charging interest
		-don’t try to be too fancy with how you calculate it, make it similar to how we made interest paid
-Transfer: from any account to any account
-Checking: account for check #s, which if you do them electronically are generally assigned automatically

How to work as a group:
-Create the repository in your account and then make everyone else a collaborator
	Settings for account: tab for collaborator, have to put github username for each person and send a request asking if they want to do this and they respond to make them a collaborator
-Collaborate and somebody build the template project (visual studio), get the startup file setup about what db you’re going to use, set up whatever folders you want (ex models folder), set up DbContext even if you don’t have any tables in it, set up once and push to repo and everyone else does a clone on it so everyone else has the same project structure
-Not just arbitrarily start adding folders outside of that structure because they can get unwieldy really quickly
-When everyone has the same code, decide who is doing what, if base class that needs to happen first
-Once first piece of code is in repo, tested and seems to work, when everyone pulls it down, one person create a new dev branch and push their project up to the dev branch and everyone pulls dev branch down and works within that to preserve what has in master, if something messes up whole project, can throw away and reclone master
-when doing own thing, create own branch, push, do pull request and merge into dev branch, you push, someone else does the merge, then everyone has to re-pull dev branch
-every time someone pushes something up, everyone has to clone it so everyone working with same code
-for most part, will be in flow from dev branch > own branch > doing own work > push up > pull request > someone else does merge > pull that merge back down 
-when pushing and merging, communicate to make sure everyone knows what’s happening and is on the same page
-part of the structure before the first clone is making sure the app settings is set up, points ot database name, startup class is fully set up, have to have dbcontext defined even if empty, make sure any folders (models) are created before clone
	-want project structure to be well set so nobody has to be adding stuff and risk inconsistencies
-Testing: if find a problem, in github, issues tab, put stuff in there or suggestions for how to change things, put in writing, lot more concrete and straightforward and creates fewer issues
	-when done, go into issues and mark them resolved
