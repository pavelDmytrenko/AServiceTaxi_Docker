import { Component, OnInit } from '@angular/core';
import { DataService } from './data.service';
import { Order } from './order';


@Component({
    templateUrl: './order-list.component.html'
})
export class OrderListComponent implements OnInit {

    orders: Order[];
    constructor(private dataService: DataService) { }

    ngOnInit() {
        this.loadOrders();
    }
    loadOrders() {
        this.dataService.getOrders().subscribe((data: Order[]) => this.orders = data);
    }
    deleteOrder(id: number) {
        this.dataService.deleteOrder(id).subscribe(data => this.loadOrders());
    }
}