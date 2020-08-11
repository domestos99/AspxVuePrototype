import Vue from 'vue'
import App from './PartnersPage.vue'

import { BootstrapVue, IconsPlugin } from 'bootstrap-vue';

import '../../styles/custom.scss'

import axios from 'axios'
import VueAxios from 'vue-axios'

Vue.use(VueAxios, axios);

// Install BootstrapVue
Vue.use(BootstrapVue);
// Optionally install the BootstrapVue icon components plugin
Vue.use(IconsPlugin);

Vue.config.productionTip = true;

new Vue({
    render: h => h(App)
}).$mount('#PartnersPage');
