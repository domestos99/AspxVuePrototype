import {PaginationModel} from '@/model/paginationModel';
import {OrderModel} from '@/model/orderModel';

const $ = require('jquery');

export default class PartnerService {

    getPartners(pagination: PaginationModel, order: OrderModel, callbackFunc): void {
        $.post('http://localhost:62873/services/TestHandler.ashx', {
            action: 'test',
            orderBy: order.orderBy,
            orderAsc: order.orderAsc,
            page: pagination.page,
            pageSize: pagination.pageSize
        }, callbackFunc);
    }

}
