import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ExpenseTypesListComponent } from './expense-types-list/expense-types-list.component';
import { ExpensesListComponent } from './expenses-list/expenses-list.component';
import { IncomeTypesListComponent } from './income-types-list/income-types-list.component';
import { IncomesListComponent } from './incomes-list/incomes-list.component';

const routes: Routes = [
    { path: 'expensesList', component: ExpensesListComponent },
    { path: 'expenseTypesList', component: ExpenseTypesListComponent },
    { path: 'incomesList', component: IncomesListComponent },
    { path: 'incomeTypesList', component: IncomeTypesListComponent },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class AccountingRoutingModule { }
