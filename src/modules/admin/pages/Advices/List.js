import React from 'react'
import { useQuery, useMutation, useQueryClient } from 'react-query'

import { getAdvices, deleteAdvice } from '../../../../services/adviceService'
import { useSelector } from 'react-redux'

import Layout from '../../layouts/Layout'
import Table from '../../../../components/Table/Table'
import { toast } from 'react-toastify'

export default function List() {
  const queryClient = useQueryClient()

	const { theme } = useSelector(state => state.theme)

	const advicesQuery = useQuery('advices', getAdvices)

	const deleteAdviceMutation = useMutation({
		mutationFn: deleteAdvice,
		onSuccess: () => {
			queryClient.invalidateQueries()
			toast.success('Advice deleted successfully', {
				theme: theme
			})
		},
	})

	const handleDelete = id => {
		deleteAdviceMutation.mutate(id)
	}

	if (advicesQuery.isLoading) {
		<div>Loading...</div>
	}

	if (advicesQuery.error) {
		<div>{JSON.stringify(advicesQuery.error)}</div>
	}

  const tableData = {
		title: 'Advice List',
		operations: { delete: handleDelete },
		headings: ['ID', 'Description'],
		rows:
			advicesQuery.data?.data?.result?.map(advice => {
				return {
					id: advice.id,
					description: advice.description,
				}
			}) || [],
	}

  return (
		<Layout><Table data={tableData} /></Layout>
	)
}
