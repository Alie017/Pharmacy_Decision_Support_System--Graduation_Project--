import React from 'react'
import { useQuery } from 'react-query'

import Layout from '../../../layouts/Layout'
import Table from '../../../../../components/Table/Table'
import { getDrugs } from '../../../../../services/drugService'

export default function List() {
	const result = useQuery('drugs', getDrugs)

	if(result.isLoading) {
		<div>Loading...</div>
	}

	if(result.error) {
		<div>{JSON.stringify(result.error)}</div>
	}

	const tableData = {
		title: 'Drug List',
		operations: {},
		headings: ['ID', 'Name', 'Barcode'],
		rows: result.data?.data?.result.map(drug => {
				return { id: drug.id, name: drug.name, barcode: drug.barcode }
			}) || []
	}

	if(result.status === 'success') {
		return <Layout><Table data={tableData} /></Layout>
	}
}
